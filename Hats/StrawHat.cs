using StardewValley;
using System;
using System.Linq;

namespace DeluxeHats.Hats
{
    public static class StrawHat
    {
        public const string Name = "Straw Hat";
        public const string Description = "When it's dawn and sunny, gain Dawn Farming Buff:\n+3 Farming";

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("straw-hat.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("straw-hat.description");

        public static void Activate()
        {
            HatService.OnUpdateTicked = (e) =>
            {
                if (Game1.isRaining || Game1.IsWinter)
                {
                    return;
                }
                if (Game1.timeOfDay > 930)
                {
                    return;
                }
                Buff farmingBuff = Game1.buffsDisplay.otherBuffs.FirstOrDefault(x => x.which == HatService.BuffId);
                if (farmingBuff == null)
                {
                    farmingBuff = new Buff(
                        farming: 3,
                        fishing: 0,
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
                        displaySource: HatService.Translation.Get("straw-hat.name"))
                    {
                        which = HatService.BuffId,
                        description = $"{HatService.Translation.Get("buffs.dawn-raining")}\n" +
                                      $"+3 {HatService.Translation.Get("attributes.farming")}",
                        millisecondsDuration = Convert.ToInt32((3.3f - ((Game1.timeOfDay - 600f) / 100f)) * 43000)
                    };

                    Game1.buffsDisplay.addOtherBuff(farmingBuff);
                }
            };
        }

        public static void Disable()
        {
            Buff farmingBuff = Game1.buffsDisplay.otherBuffs.FirstOrDefault(x => x.which == HatService.BuffId);
            if (farmingBuff != null)
            {
                farmingBuff.millisecondsDuration = 0;
            }
        }
    }
}
