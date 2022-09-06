﻿namespace DeluxeHats.Hats
{
    public static class MagicCowboyHat
    {
        public const string Name = "Magic Cowboy Hat";
        public const string Description = "No effect.";

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("magic-cowboy-hat.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("magic-cowboy-hat.description");

        public static void Activate()
        {
        }

        public static void Disable()
        {
        }
    }
}
