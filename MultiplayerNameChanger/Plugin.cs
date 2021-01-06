using IPA;
using IPA.Config.Stores;

using SiraUtil.Zenject;

using MultiplayerNameChanger.HarmonyPatches;
using MultiplayerNameChanger.Installers;

using IPALogger = IPA.Logging.Logger;
using IPAConfig = IPA.Config.Config;


namespace MultiplayerNameChanger {


    [Plugin(RuntimeOptions.SingleStartInit)]
    public class Plugin {

        internal static IPALogger Log { get; private set; }

        [Init]
        public void Init(IPALogger logger) {
            Log = logger;
            Patcher.Patch();
        }

        [Init]
        public void InitWithConfig(IPAConfig conf) {
            Configuration.PluginConfig.Instance = conf.Generated<Configuration.PluginConfig>();
        }

        [Init]
        public void InitWithZenjector(Zenjector zenjector) {
            zenjector.OnMenu<OnMenuInstaller>();
        }
    }
}
