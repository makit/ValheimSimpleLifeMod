using HarmonyLib;

namespace ValheimSimpleLifeMod
{
    [HarmonyPatch(typeof(Player), "Awake")]
    public class PlayerJumpStamina
    {
        private static void Postfix(ref Player __instance)
        {
            __instance.m_jumpStaminaUsage = 0.1f;
            __instance.m_runStaminaDrain = 0.1f;
            __instance.m_equipStaminaDrain = 0.1f;
            __instance.m_blockStaminaDrain = 0.1f;
        }
    }
}
