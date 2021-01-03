using System;
using System.Collections.Generic;
using System.IO;

namespace CustomEnvironments {


    internal static class EnvironmentLoader {


        /// <summary>
        /// <see cref="List{string}<"/> holding all Hashes of CustomScripts
        /// </summary>
        internal static List<string> scriptHashList;


        internal static bool newScriptsFound = false;

        private const string FOLDER = "CustomPlatforms";
        private const string SCRIPT_FOLDER = "Scripts";
        private const string SCRIPT_HASHES_FILENAME = "CustomScriptHashes.hashes";

        internal static readonly string customPlatformsFolderPath = Path.Combine(Environment.CurrentDirectory, FOLDER);
        internal static readonly string customPlatformsScriptFolderPath = Path.Combine(customPlatformsFolderPath, SCRIPT_FOLDER);
        internal static readonly string scriptHashesPath = Path.Combine(Environment.CurrentDirectory, "UserData", SCRIPT_HASHES_FILENAME);

        internal static List<CustomPlatform> LoadAllEnvironments() {

            if (!Directory.Exists(customPlatformsFolderPath)) {
                Directory.CreateDirectory(customPlatformsScriptFolderPath);
            }

            string[] allBundlePaths = Directory.GetFiles(customPlatformsFolderPath, "*.plat");


        }
    }
}
