using StardewValley;
using System.Linq;

namespace DeluxeHats.Hats
{
    public static class CatEars
    {
        public const string Name = "Cat Ears";
        public const string Description = "When you are hit, meow and gain Skittish Kitty Buff:\n+3 Speed\n+2 Attack";
        public static int PlayerOldHP = 0;

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("cat-ears.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("cat-ears.description");

        public static void Activate()
        {
            HatService.OnUpdateTicked = (e) =>
            {
                if (PlayerOldHP > Game1.player.health)
                {
                    Game1.playSound("cat");
                    Buff catBuff = Game1.buffsDisplay.otherBuffs.FirstOrDefault(x => x.which == HatService.BuffId);
                    if (catBuff == null)
                    {
                        catBuff = new(
                        farming: 0,
                        fishing: 0,
                        mining: 0,
                        digging: 0,
                        luck: 0,
                        foraging: 0,
                        crafting: 0,
                        maxStamina: 0,
                        magneticRadius: 0,
                        speed: 3,
                        defense: 0,
                        attack: 2,
                        minutesDuration: 1,
                        source: "Deluxe Hats",
                        displaySource: HatService.Translation.Get("cat-ears.name"))
                        {
                            which = HatService.BuffId,
                            description = $"{HatService.Translation.Get("buffs.skittish-kitty")}\n" +
                                          $"+3 {HatService.Translation.Get("attributes.speed")}\n" +
                                          $"+2 {HatService.Translation.Get("attributes.attack")}"
                        };

                        Game1.buffsDisplay.addOtherBuff(catBuff);
                    }
                    catBuff.millisecondsDuration = 1500;
                }
                PlayerOldHP = Game1.player.health;
            };
        }

        public static void Disable()
        {
            PlayerOldHP = 0;
            Buff catBuff = Game1.buffsDisplay.otherBuffs.FirstOrDefault(x => x.which == HatService.BuffId);
            if (catBuff != null)
            {
                catBuff.millisecondsDuration = 0;
            }
        }
    }
}
