using Netcode;
using StardewValley;
using StardewValley.Network;
using System;

namespace DeluxeHats.Hats
{
    public static class ArchersCap
    {
        public const string Name = "Archer's Cap";
        public const string Description = "Shots from slingshot deal more damage the further they travel.";
        public const double a = 1.0f;

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("archer's-cap.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("archer's-cap.description");

        public static void Activate()
        {
            HatService.OnUpdateTicked = (e) =>
            {
                if (Game1.player.hasMenuOpen || !Game1.player.canMove || !Game1.game1.IsActive)
                {
                    return;
                }
                if (Game1.currentLocation.projectiles.Count > 0)
                {
                    foreach (var projectile in Game1.currentLocation.projectiles)
                    {
                        if (HatService.Helper.Reflection.GetField<NetCharacterRef>(projectile, "theOneWhoFiredMe").GetValue().Get(Game1.currentLocation) is Farmer)
                        {
                            var damage = HatService.Helper.Reflection.GetField<NetInt>(projectile, "damageToFarmer").GetValue();
                            damage.Value += Convert.ToInt32(Math.Log10((a * (1f / 60f)) * projectile.travelDistance));
                        }
                    }
                }
                if (Game1.player.usingSlingshot)
                {
                }
            };
        }

        public static void Disable()
        {
        }
    }
}
