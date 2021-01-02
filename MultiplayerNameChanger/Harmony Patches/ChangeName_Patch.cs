using System.Reflection;

using HarmonyLib;

using MultiplayerNameChanger.Configuration;


namespace MultiplayerNameChanger.HarmonyPatches {


    [HarmonyPatch()]
    public class ChangeName_Patch {


        public static ConstructorInfo TargetMethod() {
            return typeof(ConnectedPlayerManager).GetNestedType("ConnectedPlayer", BindingFlags.NonPublic | BindingFlags.Instance).GetConstructors(BindingFlags.NonPublic | BindingFlags.Instance)[0];
        }

        public static void Prefix(ref string userName, ref bool isMe) {
            if (isMe && PluginConfig.Instance.UseValue && PluginConfig.Instance.NameValue != null) {
                userName = PluginConfig.Instance.NameValue;
            }
        }
    }


}
