using System.ComponentModel;

using BeatSaberMarkupLanguage.Attributes;
using BeatSaberMarkupLanguage.Parser;
using BeatSaberMarkupLanguage.ViewControllers;

using Zenject;

using MultiplayerNameChanger.Configuration;


namespace MultiplayerNameChanger.UI {


    internal class SetNameViewController : BSMLResourceViewController, INotifyPropertyChanged {

        [Inject]
        public readonly SetNameFlowCoordinator _setNameFlowCoordinator;

        public override string ResourceName => "MultiplayerNameChanger.Views.SetNameView.bsml";

        [UIParams]
        public readonly BSMLParserParams parserParams;

        [UIValue("NameValue")]
        public string NameValue {
            get => PluginConfig.Instance.NameValue;
            set { }
        }

        [UIValue("ClanValue")]
        public string ClanValue {
            get => PluginConfig.Instance.ClanValue;
            set { }
        }

        [UIValue("ClanName")]
        public string ClanName {
            get => "["+ PluginConfig.Instance.ClanValue + "]";
        }

        [UIAction("#on-enter-name")]
        public void OnEnterName(string value) {
            PluginConfig.Instance.NameValue = value;
            NotifyPropertyChanged("NameValue");
        }

        [UIAction("#on-enter-clan")]
        public void OnEnterClan(string value) {
            PluginConfig.Instance.ClanValue = value;
            NotifyPropertyChanged("ClanName");
        }
    }
}
