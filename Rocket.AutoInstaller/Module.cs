using JetBrains.Annotations;
using Rocket.AutoInstaller.Installation;
using SDG.Framework.Modules;
using SDG.Unturned;
using UnityEngine;
using UnityObject = UnityEngine.Object;

namespace Rocket.AutoInstaller;

/// <summary>
/// This is needed to run Coroutines.
/// </summary>
public class CoroutineRunner : MonoBehaviour;

[UsedImplicitly]
public class Module : IModuleNexus
{
    private const string DiscordSupportURL = "https://discord.gg/z6VM7taWeG";

    public void initialize()
    {
        var assembly = typeof(Module).Assembly;
        var assemblyName = assembly.GetName();

        CommandWindow.Log($"Loading Rocket.AutoInstaller... {assemblyName.Name} {assemblyName.Version} this could take for a while!");
        CommandWindow.Log($"Discord Support: {DiscordSupportURL}");

        var instance = new GameObject();
        UnityObject.DontDestroyOnLoad(instance);
        var coroutineRunner = instance.AddComponent<CoroutineRunner>();
        coroutineRunner.StartCoroutine(Installer.Install());
    }
    public void shutdown()
    {
    }
}