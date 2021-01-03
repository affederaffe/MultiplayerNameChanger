using System.Reflection;

using BS_Utils.Utilities;

using HarmonyLib;


using MultiplayerNameChanger.Configuration;


namespace MultiplayerNameChanger.HarmonyPatches {


    [HarmonyPatch]
    public class ChangeName_Patch {


        public static ConstructorInfo TargetMethod() {
            Plugin.Log.Log(IPA.Logging.Logger.Level.Info, typeof(UserInfo).GetConstructors()[0].ToString());
            return typeof(UserInfo).GetConstructors()[0];
        }

        public static void Postfix(UserInfo __instance) {
            if (PluginConfig.Instance.UseValue && PluginConfig.Instance.NameValue != null && PluginConfig.Instance.NameValue.Length > 0) {
                __instance.SetField("userName", PluginConfig.Instance.NameValue);
                Plugin.Log.Log(IPA.Logging.Logger.Level.Info, "Username patched to: " + __instance.userName);
            }
        }
    }


    [HarmonyPatch()]
    public class Test_Patch {

        public static MethodInfo TargetMethod() {
            return typeof(ConnectedPlayerManager).GetNestedType("ConnectedPlayer", BindingFlags.NonPublic | BindingFlags.Instance).GetMethod("CreateLocalPlayer");
        }

        public static void Postfix(ref string userName) {
            Plugin.Log.Log(IPA.Logging.Logger.Level.Info, "Username: " + userName);
        }
    }
}
