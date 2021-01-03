using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using IPA;
using IPA.Config;
using IPA.Config.Stores;

using UnityEngine;
using UnityEngine.SceneManagement;

using SiraUtil.Zenject;

using CustomEnvironments.Installers;

using IPALogger = IPA.Logging.Logger;


namespace CustomEnvironments {
    [Plugin(RuntimeOptions.SingleStartInit)]
    public class Plugin {


        [Init]
        /// <summary>
        /// Called when the plugin is first loaded by IPA (either when the game starts or when the plugin is enabled if it starts disabled).
        /// [Init] methods that use a Constructor or called before regular methods like InitWithConfig.
        /// Only use [Init] with one Constructor.
        /// </summary>
        public void Init(IPALogger logger) {
            Utils.Logger.IPALogger = logger;
            Utils.Logger.Log("CustomEnvironments initialized.");
        }

        [Init]
        public void InitWithConfig(Config conf) {
            Configuration.PluginConfig.Instance = conf.Generated<Configuration.PluginConfig>();
            Utils.Logger.Log("Config loaded");
        }

        [Init]
        public void InitWithZenjector(Zenjector zenjector) {
            zenjector.OnApp<OnAppInstaller>();
        }

        [OnStart]
        public void OnApplicationStart() {
            Utils.Logger.Log("OnApplicationStart");
            new GameObject("CustomEnvironmentsController").AddComponent<CustomEnvironmentsController>();

        }

        [OnExit]
        public void OnApplicationQuit() {
            Utils.Logger.Log("OnApplicationQuit");
        }
    }
}
