using Microsoft.Xna.Framework;
using StardewValley;
using System.Linq;

namespace DeluxeHats.Hats
{
    public static class SailorsCap
    {
        public const string Name = "Sailor's Cap";
        public const string Description = "When tipsy gain the Drunken Sailor Buff:\n+10 Attack";

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("sailor's-hat.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("sailor's-hat.description");

        public static void Activate()
        {
            HatService.OnUpdateTicked = (e) =>
            {
                Buff tipsyBuff = Game1.buffsDisplay.otherBuffs.FirstOrDefault(x => x.which == Buff.tipsy);
                if (tipsyBuff != null)
                {
                    Buff powerBuff = Game1.buffsDisplay.otherBuffs.FirstOrDefault(x => x.which == HatService.BuffId);
                    if (powerBuff == null)
                    {
                        powerBuff = new(
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            attack: 10,
                            minutesDuration: 1,
                            source: "Deluxe Hats",
                            displaySource: HatService.Translation.Get("sailor's-hat.name"))
                        {
                            which = HatService.BuffId,
                            description = $"{HatService.Translation.Get("buffs.drunken-sailor")}\n" +
                                          $"+10 {HatService.Translation.Get("attributes.attack")}"
                        };

                        Game1.buffsDisplay.addOtherBuff(powerBuff);
                        Game1.player.startGlowing(Color.OrangeRed * 0.5f, false, 0.08f);
                    }

                    powerBuff.millisecondsDuration = tipsyBuff.millisecondsDuration;
                }

                else if (Game1.player.isGlowing && Game1.player.glowingColor == Color.OrangeRed * 0.5f)
                {
                    Game1.player.stopGlowing();
                }
            };
        }

        public static void Disable()
        {
            Buff powerBuff = Game1.buffsDisplay.otherBuffs.FirstOrDefault(x => x.which == HatService.BuffId);

            if (powerBuff != null)
            {
                powerBuff.millisecondsDuration = 0;
            }
        }
    }
}
