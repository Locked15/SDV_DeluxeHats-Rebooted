using StardewValley;
using System;
using System.Linq;

namespace DeluxeHats.Hats
{
    public static class Souwester
    {
        public const string Name = "Sou'wester";
        public const string Description = "While outside in the rain, gain the Fishing in the Rain Buff:\n+4 Fishing";

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("sou'wester.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("sou'wester.description");

        public static void Activate()
        {
            HatService.OnUpdateTicked = (e) =>
            {
                Buff fishingBuff = Game1.buffsDisplay.otherBuffs.FirstOrDefault(x => x.which == HatService.BuffId);
                if (!Game1.isRaining || !Game1.currentLocation.IsOutdoors)
                {
                    if (fishingBuff != null)
                    {
                        fishingBuff.millisecondsDuration = 0;
                    }
                    return;
                }
                if (fishingBuff == null)
                {
                    fishingBuff = new(
                        farming: 0,
                        fishing: 4,
                        mining: 0,
                        digging: 0,
                        luck: 0,
                        foraging: 0,
                        crafting: 0,
                        maxStamina: 0,
                        magneticRadius: 0,
                        speed: 0,
                        defense: 0,
                        attack: 0,
                        minutesDuration: 1,
                        source: "Deluxe Hats",
                        displaySource: HatService.Translation.Get("sou'wester.name"))
                    {
                        which = HatService.BuffId,
                        description = $"{HatService.Translation.Get("buffs.fishing-in-rain")}\n" +
                                      $"+4 {HatService.Translation.Get("attributes.fishing")}",
                        millisecondsDuration = Convert.ToInt32((20f - ((Game1.timeOfDay - 600f) / 100f)) * 43000)
                    };

                    Game1.buffsDisplay.addOtherBuff(fishingBuff);
                }
            };
        }

        public static void Disable()
        {
            Buff fishinBuff = Game1.buffsDisplay.otherBuffs.FirstOrDefault(x => x.which == HatService.BuffId);
            if (fishinBuff != null)
            {
                fishinBuff.millisecondsDuration = 0;
            }
        }
    }
}
