using SiraUtil;

using Zenject;

using MultiplayerNameChanger.UI;

namespace MultiplayerNameChanger.Installers {


    internal class OnMenuInstaller : Installer {

        public override void InstallBindings() {
            Container.BindViewController<SetNameViewController>();
            Container.BindFlowCoordinator<SetNameFlowCoordinator>();
            Container.BindInterfacesAndSelfTo<Settings>().AsSingle();
            Container.BindInterfacesTo<MenuButtonManager>().AsSingle();
        }
    }
}