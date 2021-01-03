using BeatSaberMarkupLanguage.Attributes;

using Zenject;


namespace MultiplayerNameChanger.UI {


    internal class Settings {

        [Inject]
        public readonly MenuTransitionsHelper menuTransitionsHelper;

        [UIValue("#use")]
        public static bool Use {
            get => Configuration.PluginConfig.Instance.UseValue;
            set => Configuration.PluginConfig.Instance.UseValue = value;
        }
    }
}
