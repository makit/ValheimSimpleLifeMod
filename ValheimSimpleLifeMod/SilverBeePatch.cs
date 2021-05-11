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
			if(rnd.Next(100) > 80) 
            {
				var silver = ObjectDB.instance.GetItemPrefab("Silver").GetComponent<ItemDrop>();
				__instance.m_honeyItem = silver;
			}

			// For testing... or cheating
			//__instance.m_maxHoney = 30;
			//__instance.m_secPerUnit = 30;
		}
	}
}