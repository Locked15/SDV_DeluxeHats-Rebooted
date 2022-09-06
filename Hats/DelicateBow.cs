﻿using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewValley;
using System;

namespace DeluxeHats.Hats
{
    public static class DelicateBow
    {
        public const string Name = "Delicate Bow";
        public const string Description = "Sparkles inside!\nPeople in the same inside area as you will gain 5 friendship every 7 seconds.";

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("delicate-bow.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("delicate-bow.description");


        private static readonly IReflectedField<Multiplayer> multiplayer = HatService.Helper.Reflection.GetField<Multiplayer>(typeof(Game1), "multiplayer");
        public static void Activate()
        {
            HatService.OnUpdateTicked = (e) =>
            {
                if (Game1.currentLocation.IsOutdoors || Game1.player.hasMenuOpen || !Game1.player.canMove || !Game1.game1.IsActive)
                {
                    return;
                }
                if (e.Ticks % 480 == 0)
                {
                    multiplayer.GetValue().broadcastSprites(Game1.currentLocation, Utility.sparkleWithinArea(new Rectangle(Convert.ToInt32(Game1.player.position.X), Convert.ToInt32(Game1.player.position.Y) - 128, 32, 32), 2, Color.DeepPink));
                    foreach (var npc in Game1.currentLocation.getCharacters())
                    {
                        Game1.player.changeFriendship(5, npc);
                    }
                }

            };
        }

        public static void Disable()
        {
        }
    }
}
