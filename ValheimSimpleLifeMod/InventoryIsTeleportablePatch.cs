using HarmonyLib;

namespace ValheimSimpleLifeMod
{
    [HarmonyPatch(typeof(Inventory), nameof(Inventory.IsTeleportable))]
    public static class InventoryIsTeleportablePatch
    {
        private static void Postfix(ref bool __result)
        {
            __result = true;
        }
    }
}
