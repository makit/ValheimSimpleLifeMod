using HarmonyLib;
using System;

namespace ValheimSimpleLifeMod
{
    [HarmonyPatch(typeof(Beehive), "Awake")]
    public static class SilverBeePatch
    {
		private static void Postfix(ref Beehive __instance)
		{
			var rnd = new Random();
			if(rnd.Next(100) > 50)
            {
				var silverOre = ObjectDB.instance.GetItemPrefab("Silver").GetComponent<ItemDrop>();
				__instance.m_honeyItem = silverOre;
			}

			__instance.m_maxHoney = 20;

			// For testing... or cheating
			// __instance.m_secPerUnit = 60;
		}
	}
}