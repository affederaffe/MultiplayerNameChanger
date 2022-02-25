using SiraUtil;

using Zenject;

using MultiplayerNameChanger.UI;


namespace MultiplayerNameChanger.Installers {


    internal class OnMenuInstaller : Installer {

        public override void InstallBindings() {
            Container.Bind<SetNameViewController>().FromNewComponentAsViewController().AsSingle();
            Container.Bind<SetNameFlowCoordinator>().FromNewComponentOnNewGameObject().AsSingle();
            Container.BindInterfacesAndSelfTo<Settings>().AsSingle();
            Container.BindInterfacesTo<MenuButtonManager>().AsSingle();
        }
    }
}