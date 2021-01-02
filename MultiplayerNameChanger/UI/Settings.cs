using BeatSaberMarkupLanguage.Attributes;


namespace MultiplayerNameChanger.UI {


    internal class Settings : PersistentSingleton<Settings> {

        [UIValue("#use")]
        public static bool Use {
            get {
                return Configuration.PluginConfig.Instance.UseValue;
            }
            set {
                Configuration.PluginConfig.Instance.UseValue = value;
            }
        }
    }
}
