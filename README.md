# ![RocketModFix][rocketmodfix_logo]

## RocketModFix

The **RocketModFix** is a fork of RocketMod for Unturned maintained by the Unturned plugin devs, this fork don't have plans for any major changes to the RocketMod, only fixes and new features that doesn't break any backward compatibility with API.

## Compatibility

You can still use old plugins without any changes/recompilation/updates.

## Our plan and what we're done

- [x] Create Discord Server Community.
- [x] UnityEngine NuGet Package redist.
- [x] Unturned NuGet Package redist.
- [x] Update MSBuild to the `Microsoft.NET.Sdk`, because current MSBuild in RocketMod is outdated and its hard to support and understand what's going on inside.
- [x] RocketMod NuGet Package containing all required libraries for RockeMod API usage.
- [x] CI/CD and nightly builds with RocketMod .dlls.
- [x] Automatic Release on Tag creation (with RocketMod Module).
- [x] Rocket.Unturned.Module Artifacts on PR.
- [x] Rocket.Unturned NuGet Package.
- [x] Reset changelog.
- [x] For versioning use [SemVer][semver_url].
- [x] Installation guides inside of the Rocket Unturned Module.
- [x] Rocket.AutoInstaller to automaticaly install Rocket.
- [x] Keep backward compatibility.
	- [x] Test with RocketMod plugins that uses old RocketMod libraries, and make sure current changes doesn't break anything.
	- [x] Test with most used Modules:
		- [x] AviRockets.
		- [x] uScript.
		- [x] OpenMod.
- [ ] RocketMod Fixes:
	- [x] Fix UnturnedPlayer.SteamProfile, current implementation cause so many lags (fixed, but still requires fixes). 
	- [x] Fix UnturnedPlayerComponent is not being added and removed automatically.
	- [x] /admin /unadmin doesn't work when use offline player (now it possible to use steam id of the offline player).
	- [ ] Assembly Resolve fixes (don't spam with not found library or make a option to disable it, load all libraries at rocketmod start instead of searching for them only on OnAssemblyResolve)
	- [x] Fix problem when TaskDispatcher is not calling an action (example: when some plugins queue a player which connected to the server the action might not be called = bypassed checks/bans etc).
	- [ ] Commands fixes:
		- [ ] Fix /vanish.
		- [x] Fix /god. (oxygen isn't fixed)
		- [ ] Fix /p (not readable at all).
	- [ ] Perfomance.
- [x] New Features:
	- [x] Commands:
		- [x] /position /pos (current position of the player).
		- [x] /tpwp (improved version of /tp wp).
		- [x] /savelogs (a fast way for sending logs to plugin developer or whatever).
- [ ] Remove Features:
	- [x] Command /compass
- [x] Gather a Team with a direct access to the repo edit without admins help. (We still gather a team)
- [ ] RocketModFix Video Installation Guide (could be uploaded on YouTube).

After plan is finished -> Add new plans, keep coding, and don't forget to approve PR or issues.

## Installation

Now we have 2 different ways you can install Rocket, either `Standard Way` or `Auto-Installer`, select the one you like more, but we highly recommend to use `Auto-Installer`.

### Standard Way

1. **Stop the Server**: If your server is running, stop it.
2. **Remove Old Rocket**: Delete the entire `Rocket.Unturned` folder located in `Modules` (if it exists).
3. **Download the Latest RocketModFix**: Go to the [RocketModFix releases page](https://github.com/RocketModFix/RocketModFix/releases).
4. **Access the Assets**: Open the "Assets" section if it's not already expanded.
5. **Download the Module**: Click `Rocket.Unturned.Module.zip` to download the latest module.
6. **Final**: Extract the downloaded archive, open the `Rocket.Unturned.Module` folder, and copy the `Rocket.Unturned` folder to `Modules` (copy the folder, not it's content, and if its asks to Replace the existing files then press to replace them).

### Auto-Installer (new way)

It's same as installing Rocket manually (standard way), however if we make an update you will receive it automatically, so you don't need to remove old Rocket, replace/delete files, etc.

See more info [here](https://github.com/RocketModFix/RocketModFix/blob/master/Rocket.AutoInstaller/README.md) about it if you're interested how it work and what we're planning to do next with it.

1. **Stop the Server**: If your server is running, stop it.
2. **Remove Rocket** (if you still have it): Delete the entire `Rocket.Unturned` folder located in `Modules` (if it exists).
3. **Download the Latest Rocket.AutoInstaller**: Go to the [RocketModFix releases page](https://github.com/RocketModFix/RocketModFix/releases).
4. **Access the Assets**: Open the "Assets" section if it's not already expanded.
5. **Download the Rocket.AutoInstaller**: Click `Rocket.AutoInstaller.zip` to download the latest module.
6. **Final**: Extract the downloaded archive, open the `Rocket.AutoInstaller` folder, and copy the `Rocket.AutoInstaller` folder to `Modules` (copy the folder, not it's content, and if its asks to Replace the existing files then press to replace them).

Contact in our discord if you have any problems. Just in case you can also read `Readme_EN.txt` or `Readme_RU.txt` inside of the installed Module.

## Discord

Feel free to join our [Discord Server][discordserver_url].

## We're used by

- [ALKAD Hosting][hosting_alkad]

If you also use RocketModFix, contact us, we will add a link to you!

## How to Contribute
We're thrilled to have you here! Feel free to create pull requests (PRs) and open issues - your contributions are valuable to us!

### Why We Use Issues
Before you dive into making changes, consider creating an [issue][issues_url] or discussions on our [discord server][discordserver_url] first. Here's why:

- Avoid Duplicate Work: Someone might already be working on a similar update. Checking issues prevents duplication of effort.
- Collaborative Problem Solving: Other contributors might have valuable insights or alternative solutions. Discussing changes beforehand can lead to better implementations.
- Save Your Time: Avoid working on updates that might not align with the project's direction. Consult with others to ensure your efforts are fruitful.

### Guidelines for Contributors

Follow these guidelines to make our work smoother and faster, otherwise your change might not be accepted:

1. **Check for Compatibility**: 
   - Does your change break backward compatibility? 
   - If it does then your change might not accepted, keep it compatible with old versions.

2. **Ensure Broad Usability**: 
   - Will your changes work with other versions of Rocket or older versions, or if other Rocket for example [LDM][ldm_github_repository] installed but your edited version of RocketModFix is not installed?
   - If not, your change may not be accepted as it could cause problems such as breaking changes.

3. **Test Your Changes**:
   - Have you tested your change locally or in a test environment?
   - If not, test it to confirm it works as expected.

4. **Keep Things Simple**:
	- Do you keep things simple?
	- If not, try to keep things simple, for example: "Don't try to make things/code unique, hard, complex, etc, use and do simple and working solutions for the issue, no need to show yourself as a hulk.".

Keep these points in mind to help everyone use RocketModFix without issues.

## NuGet Packages

### Redist

[![RocketModFix.Unturned.Redist][badge_RocketModFix.Unturned.Redist]][nuget_package_RocketModFix.Unturned.Redist]

[![RocketModFix.UnityEngine.Redist][badge_RocketModFix.UnityEngine.Redist]][nuget_package_RocketModFix.UnityEngine.Redist]

### RocketModFix

[![RocketModFix.Rocket.API][badge_RocketModFix.Rocket.API]][nuget_package_RocketModFix.Rocket.API]

[![RocketModFix.Rocket.Core][badge_RocketModFix.Rocket.Core]][nuget_package_RocketModFix.Rocket.Core]

[![RocketModFix.Rocket.Unturned][badge_RocketModFix.Rocket.Unturned]][nuget_package_RocketModFix.Rocket.Unturned]

## Resources

fr34kyn01535 has listed all of the original plugins in a post to the /r/RocketMod subreddit: [List of plugins from the old repository](https://www.reddit.com/r/rocketmod/comments/ek4i7b/)

Following closure of the original forum the recommended sites for developer discussion are the [/r/UnturnedLDM](https://www.reddit.com/r/UnturnedLDM/) subreddit, [SDG Forum](https://forum.smartlydressedgames.com/c/modding/ldm), or the [Steam Discussions](https://steamcommunity.com/app/304930/discussions/17/).

The RocketMod organization on GitHub hosts several related archived projects: [RocketMod (Abandoned)](https://github.com/RocketMod)

## History

On the 20th of December 2019 Sven Mawby "fr34kyn01535" and Enes Sadık Özbek "Trojaner" officially ceased maintenance of Rocket. They kindly released the source code under the MIT license. [Read their full farewell statement here.](https://github.com/RocketMod/Rocket/blob/master/Farewell.md)

Following their resignation SDG forked the repository to continue maintenance in sync with the game.

On the 2nd of June 2020 fr34kyn01535 requested the fork be rebranded to help distance himself from the project.

## Credits

[OpenMod][openmod_github_repository] for nuget packages ready-to-go actions and workflows.

[keep_a_changelog_url]: https://keepachangelog.com/en/1.1.0/
[semver_url]: https://semver.org/

[rocketmodfix_logo]: https://raw.githubusercontent.com/RocketModFix/RocketModFix/master/resources/RocketModFix.png

[issues_url]: https://github.com/RocketModFix/RocketModFix/issues

[nuget_package_RocketModFix.Unturned.Redist]: https://www.nuget.org/packages/RocketModFix.Unturned.Redist
[badge_RocketModFix.Unturned.Redist]: https://img.shields.io/nuget/v/RocketModFix.Unturned.Redist?label=RocketModFix.Unturned.Redist&link=https%3A%2F%2Fwww.nuget.org%2Fpackages%2FRocketModFix.Unturned.Redist

[nuget_package_RocketModFix.UnityEngine.Redist]: https://www.nuget.org/packages/RocketModFix.UnityEngine.Redist
[badge_RocketModFix.UnityEngine.Redist]: https://img.shields.io/nuget/v/RocketModFix.UnityEngine.Redist?label=RocketModFix.UnityEngine.Redist&link=https%3A%2F%2Fwww.nuget.org%2Fpackages%2FRocketModFix.UnityEngine.Redist

[nuget_package_RocketModFix.Rocket.API]: https://www.nuget.org/packages/RocketModFix.Rocket.API
[badge_RocketModFix.Rocket.API]: https://img.shields.io/nuget/v/RocketModFix.Rocket.API?label=RocketModFix.Rocket.API&link=https%3A%2F%2Fwww.nuget.org%2Fpackages%2FRocketModFix.Rocket.API

[nuget_package_RocketModFix.Rocket.Core]: https://www.nuget.org/packages/RocketModFix.Rocket.Core
[badge_RocketModFix.Rocket.Core]: https://img.shields.io/nuget/v/RocketModFix.Rocket.Core?label=RocketModFix.Rocket.Core&link=https%3A%2F%2Fwww.nuget.org%2Fpackages%2FRocketModFix.Rocket.Core

[nuget_package_RocketModFix.Rocket.Unturned]: https://www.nuget.org/packages/RocketModFix.Rocket.Unturned
[badge_RocketModFix.Rocket.Unturned]: https://img.shields.io/nuget/v/RocketModFix.Rocket.Unturned?label=RocketModFix.Rocket.Unturned&link=https%3A%2F%2Fwww.nuget.org%2Fpackages%2FRocketModFix.Rocket.Unturned

[hosting_alkad]: https://hosting.alkad.org/

[discordserver_url]: https://discord.gg/z6VM7taWeG 

[openmod_github_repository]: https://github.com/openmod/openmod
[ldm_github_repository]: https://github.com/SmartlyDressedGames/Legally-Distinct-Missile