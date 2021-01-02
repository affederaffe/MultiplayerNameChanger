using BeatSaberMarkupLanguage;

using HMUI;

using Zenject;

namespace MultiplayerNameChanger.UI {


    internal class SetNameFlowCoordinator : FlowCoordinator {

        [Inject]
        private readonly SetNameViewController _setNameViewController;

        protected override void DidActivate(bool firstActivation, bool addedToHierarchy, bool screenSystemEnabling) {
            if (firstActivation) {
                showBackButton = true;
                SetTitle("Change Mutliplayer Name");
                ProvideInitialViewControllers(_setNameViewController);
            }
            _setNameViewController.ActivateKeyboard();
        }

        protected override void BackButtonWasPressed(ViewController topViewController) {
            base.BackButtonWasPressed(topViewController);
            BeatSaberUI.MainFlowCoordinator.DismissFlowCoordinator(this);
        }
    }
}
