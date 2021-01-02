using System.Collections.Generic;

using BeatSaberMarkupLanguage;
using BeatSaberMarkupLanguage.Attributes;
using BeatSaberMarkupLanguage.Parser;
using BeatSaberMarkupLanguage.ViewControllers;

using UnityEngine;

using Zenject;


namespace MultiplayerNameChanger.UI {


    internal class SetNameViewController : BSMLResourceViewController {


        [Inject]
        public readonly SetNameFlowCoordinator _setNameFlowCoordinator;

        public override string ResourceName => "MultiplayerNameChanger.UI.SetNameView.bsml";

        [UIParams]
        public readonly BSMLParserParams parserParams;

        [UIValue("NameValue")]
        public string NameValue = Configuration.PluginConfig.Instance.NameValue;

        [UIAction("#on-enter")]
        public void OnEnter(string value) {
            Configuration.PluginConfig.Instance.NameValue = value;
            NameValue = value;
            BeatSaberUI.MainFlowCoordinator.DismissFlowCoordinator(_setNameFlowCoordinator);
        }

        internal void ActivateKeyboard() {
            SharedCoroutineStarter.instance.StartCoroutine(WaitAndShowKeyboard());
        }

        private IEnumerator<WaitForSeconds> WaitAndShowKeyboard() {
            yield return new WaitForSeconds(0.5f);
            parserParams.EmitEvent("#show-event");
        }
    }
}
