﻿using System;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using Rocket.API;
using Rocket.API.Serialisation;
using Rocket.Core;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Extensions;
using Rocket.Unturned.Player;
using SDG.Unturned;
using Steamworks;
using UnityEngine;

namespace Rocket.Unturned.Permissions
{
    public class UnturnedPermissions : MonoBehaviour
    {
        public delegate void JoinRequested(CSteamID player, ref ESteamRejection? rejectionReason);
        public static event JoinRequested OnJoinRequested;

        [EditorBrowsable(EditorBrowsableState.Never)]
        internal static bool CheckPermissions(SteamPlayer caller, string permission)
        {
            UnturnedPlayer player = caller.ToUnturnedPlayer();

            Regex r = new Regex("^\\/\\S*");
            string requestedCommand = r.Match(permission.ToLower()).Value.TrimStart('/').ToLower();

            var command = R.Commands.GetCommand(requestedCommand);

            if (command == null)
            {
                UnturnedChat.Say(player, U.Translate("command_not_found"), Color.red);
                return false;
            }
            if (!R.Permissions.HasPermission(player, command))
            {
                UnturnedChat.Say(player, U.Translate("command_no_permission"), Color.red);
                return false;
            }

            var cooldown = R.Commands.GetCooldown(player, command);
            if (cooldown <= 0)
                return true;

            UnturnedChat.Say(player, R.Translate("command_cooldown", cooldown), Color.red);
            return false;
        }

        internal static bool CheckValid(ValidateAuthTicketResponse_t r)
        {
            ESteamRejection? reason = null;

            try
            {
                var playerGroups = R.Permissions.GetGroups(
                    new RocketPlayer(r.m_SteamID.ToString()),
                    true
                );

                string? prefix =
                    playerGroups.FirstOrDefault(x => !string.IsNullOrEmpty(x.Prefix))?.Prefix ?? "";
                string? suffix =
                    playerGroups.FirstOrDefault(x => !string.IsNullOrEmpty(x.Suffix))?.Suffix ?? "";

                SteamPending? steamPending = Provider.pending.FirstOrDefault(x =>
                    x.playerID.steamID == r.m_SteamID
                );
                if (steamPending != null)
                {
                    if (!string.IsNullOrEmpty(prefix))
                    {
                        steamPending.playerID.characterName =
                            $"{prefix}{steamPending.playerID.characterName}";
                    }

                    if (!string.IsNullOrEmpty(suffix))
                    {
                        steamPending.playerID.characterName += suffix;
                    }
                }
            }
            catch (Exception ex)
            {
                Core.Logging.Logger.Log(
                    $"Failed adding prefix/suffix to player {r.m_SteamID}: {ex}"
                );
            }
            if (OnJoinRequested == null)
                return true;

            foreach (var handler in OnJoinRequested.GetInvocationList().Cast<JoinRequested>())
            {
                try
                {
                    handler(r.m_SteamID, ref reason);
                    if (!reason.HasValue)
                        continue;

                    Provider.reject(r.m_SteamID, reason.Value);
                    return false;
                }
                catch (Exception ex)
                {
                    Core.Logging.Logger.LogException(ex);
                }
            }

            return true;
        }
    }
}
