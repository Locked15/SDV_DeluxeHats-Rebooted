using Microsoft.Xna.Framework;
using StardewValley;
using System;

namespace DeluxeHats.Hats
{
    public static class GoldenMask
    {
        public const string Name = "Golden Mask";
        public const string Description = "Damage enemies near you every 3 seconds, the damage can kill mummies.";

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("golden-mask.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("golder-mask.description");

        public static void Activate()
        {
            HatService.OnUpdateTicked = (e) =>
            {
                if (Game1.player.hasMenuOpen || !Game1.player.canMove || !Game1.game1.IsActive)
                {
                    return;
                }
                if (e.IsMultipleOf(180))
                {
                    var rect = new Rectangle(
                        x: Convert.ToInt32(Game1.player.position.X - 320),
                        y: Convert.ToInt32(Game1.player.position.Y - 320),
                        width: 640,
                        height: 640);
                    Game1.currentLocation.damageMonster(rect, 1, 20, true, Game1.player);
                }
            };
        }

        public static void Disable()
        {
        }
    }
}
