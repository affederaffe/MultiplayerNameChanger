using System;

using BeatSaberMarkupLanguage;
using BeatSaberMarkupLanguage.MenuButtons;
using BeatSaberMarkupLanguage.Settings;

using Zenject;


namespace MultiplayerNameChanger.UI {


    internal class MenuButtonManager : IInitializable, IDisposable {

        private readonly MenuButton _menuButton;
        private readonly SetNameFlowCoordinator _setNameFlowCoordinator;

        public MenuButtonManager(SetNameFlowCoordinator setNameFlowCoordinator) {
            _setNameFlowCoordinator = setNameFlowCoordinator;
            _menuButton = new MenuButton("Name Changer", "Change your Multiplayer name here!", SummonFlowCoordinator);
        }

        public void Initialize() {
            MenuButtons.instance.RegisterButton(_menuButton);
            BSMLSettings.instance.AddSettingsMenu("Name Changer", "MultiplayerNameChanger.UI.SettingsView.bsml", Settings.instance);
        }

        public void Dispose() {
            MenuButtons.instance.UnregisterButton(_menuButton);
        }

        private void SummonFlowCoordinator() {
            BeatSaberUI.MainFlowCoordinator.PresentFlowCoordinator(_setNameFlowCoordinator);
        }
    }
}
