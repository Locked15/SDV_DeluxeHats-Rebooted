using HarmonyLib;
using StardewValley;
using StardewValley.Events;
using System;

namespace DeluxeHats.Hats
{
    public static class WitchHat
    {
        public const string Name = "Witch Hat";
        public const string Description = "When sleeping, increase chance for the witch farm event.";

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("witch-hat.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("witch-hat.description");

        public static void Activate()
        {
            HatService.Harmony.Patch(
                original: AccessTools.Method(typeof(Utility), nameof(Utility.pickFarmEvent)),
                postfix: new HarmonyMethod(typeof(WitchHat), nameof(WitchHat.PickFarmEvent_Postfix)));
        }

        public static void Disable()
        {
            HatService.Harmony.Unpatch(
                  AccessTools.Method(typeof(Utility), nameof(Utility.pickFarmEvent)),
                  HarmonyPatchType.Postfix,
                  HatService.HarmonyId);
        }

        public static void PickFarmEvent_Postfix(ref FarmEvent __result)
        {
            try
            {
                if (__result == null)
                {
                    if (Game1.random.NextDouble() < 0.45)
                    {
                        __result = new WitchEvent();
                    }
                }
            }
            catch (Exception ex)
            {
                HatService.Monitor.Log($"Failed in {nameof(PickFarmEvent_Postfix)}:\n{ex}");
            }
        }
    }
}
