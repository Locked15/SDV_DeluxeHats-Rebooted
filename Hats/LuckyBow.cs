using StardewValley;
using System;
using System.Linq;

namespace DeluxeHats.Hats
{
    public static class LuckyBow
    {
        public const string Name = "Lucky Bow";
        public const string Description = "Gain Lucky charm Buff:\n+1 Luck";

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("lucky-bow.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("lucky-bow.description");

        public static void Activate()
        {
            HatService.OnUpdateTicked = (e) =>
            {
                Buff luckBuff = Game1.buffsDisplay.otherBuffs.FirstOrDefault(x => x.which == HatService.BuffId);
                if (luckBuff == null)
                {
                    luckBuff = new(
                        farming: 0,
                        fishing: 0,
                        mining: 0,
                        digging: 0,
                        luck: 1,
                        foraging: 0,
                        crafting: 0,
                        maxStamina: 0,
                        magneticRadius: 0,
                        speed: 0,
                        defense: 0,
                        attack: 0,
                        minutesDuration: 1,
                        source: "Deluxe Hats",
                        displaySource: HatService.Translation.Get("lucky-bow.name"))
                    {
                        which = HatService.BuffId,
                        description = $"{HatService.Translation.Get("buffs.lucky-charming")}\n" +
                                      $"+1 {HatService.Translation.Get("attributes.luck")}",
                        millisecondsDuration = Convert.ToInt32((20f - ((Game1.timeOfDay - 600f) / 100f)) * 43000)
                    };

                    Game1.buffsDisplay.addOtherBuff(luckBuff);
                }
            };
        }

        public static void Disable()
        {
            Buff luckBuff = Game1.buffsDisplay.otherBuffs.FirstOrDefault(x => x.which == HatService.BuffId);
            if (luckBuff != null)
            {
                luckBuff.millisecondsDuration = 0;
            }
        }
    }
}
