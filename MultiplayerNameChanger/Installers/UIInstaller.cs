using SiraUtil;

using Zenject;

using MultiplayerNameChanger.UI;

namespace MultiplayerNameChanger.Installers {


    internal class UIInstaller : Installer {

        public override void InstallBindings() {
            Container.BindViewController<SetNameViewController>();
            Container.BindFlowCoordinator<SetNameFlowCoordinator>();
            Container.BindInterfacesTo<MenuButtonManager>().AsSingle();
        }
    }
}
