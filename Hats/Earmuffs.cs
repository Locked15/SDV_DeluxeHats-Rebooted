using StardewValley;
using System;
using System.Linq;

namespace DeluxeHats.Hats
{
    public static class Earmuffs
    {
        public const string Name = "Earmuffs";
        public const string Description = "When outside in winter get the Season Protection Buff:\n+2 Foraging\n+1 Farming\n+1 Fishing";

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("earmuffs.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("earmuffs.description");

        public static void Activate()
        {
            HatService.OnUpdateTicked = (e) =>
            {
                Buff earmuffBuff = Game1.buffsDisplay.otherBuffs.FirstOrDefault(x => x.which == HatService.BuffId);
                if (Game1.currentLocation.IsOutdoors && Game1.currentSeason == "winter")
                {
                    if (earmuffBuff == null)
                    {
                        earmuffBuff = new(
                            farming: 1,
                            fishing: 1,
                            mining: 0,
                            digging: 0,
                            luck: 0,
                            foraging: 2,
                            crafting: 0,
                            maxStamina: 0,
                            magneticRadius: 0,
                            speed: 0,
                            defense: 0,
                            attack: 0,
                            minutesDuration: 1,
                            source: "Deluxe Hats",
                            displaySource: HatService.Translation.Get("earmuffs.name"))
                        {
                            which = HatService.BuffId,
                            description = $"{HatService.Translation.Get("buffs.season-protection")}\n" +
                                          $"+2 {HatService.Translation.Get("attributes.foraging")}\n" +
                                          $"+1 {HatService.Translation.Get("attributes.farming")}\n" +
                                          $"+1 {HatService.Translation.Get("attributes.fishing")}",
                            millisecondsDuration = Convert.ToInt32((20f - ((Game1.timeOfDay - 600f) / 100f)) * 43000)
                        };

                        Game1.buffsDisplay.addOtherBuff(earmuffBuff);
                    }
                }
                else
                {
                    if (earmuffBuff != null)
                    {
                        earmuffBuff.millisecondsDuration = 0;
                    }
                }
            };
        }

        public static void Disable()
        {
            Buff earmuffBuff = Game1.buffsDisplay.otherBuffs.FirstOrDefault(x => x.which == HatService.BuffId);
            if (earmuffBuff != null)
            {
                earmuffBuff.millisecondsDuration = 0;
            }
        }
    }
}
