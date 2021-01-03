using Zenject;

namespace CustomEnvironments.Installers {


    internal class OnAppInstaller : Installer {

        public override void InstallBindings() {
            Container.InstantiatePrefab();
        }
    }
}
