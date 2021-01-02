using HarmonyLib;

using IPA;
using System;

using IPA.Config;
using IPA.Config.Stores;

using SiraUtil.Zenject;

using MultiplayerNameChanger.Installers;

using IPALogger = IPA.Logging.Logger;
using IPAConfig = IPA.Config.Config;


namespace MultiplayerNameChanger {
    [Plugin(RuntimeOptions.SingleStartInit)]
    public class Plugin {

        internal static IPALogger Log { get; private set; }
        internal static Harmony Harmony = new Harmony("de.affederaffe.multiplayernamechanger");

        [Init]
        public void Init(IPALogger logger) {
            Log = logger;
            Harmony.PatchAll();
        }

        [Init]
        public void InitWithConfig(IPAConfig conf) {
            Configuration.PluginConfig.Instance = conf.Generated<Configuration.PluginConfig>();
        }

        [Init]
        public void InitWithZenjector(Zenjector zenjector) {
            zenjector.OnMenu<UIInstaller>();
        }
    }
}
