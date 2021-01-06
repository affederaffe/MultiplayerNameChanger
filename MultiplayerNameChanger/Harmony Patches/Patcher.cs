using System.Reflection;

using HarmonyLib;


namespace MultiplayerNameChanger.HarmonyPatches {


    internal static class Patcher {

        private static bool runOnce = false;

        internal static void Patch() {
            if (!runOnce) {
                new Harmony("de.affederaffe.multiplayernamechanger").PatchAll(Assembly.GetExecutingAssembly());
                runOnce = true;
            }
        }
    }
}
