namespace DeluxeHats.Hats
{
    public static class PirateHat
    {
        public const string Name = "Pirate Hat";
        public const string Description = "Double the chance to find treasure while fishing";

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("pirate-hat.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("pirate-hat.description");

        private const int pirateTreasureChanceMultiplyer = 2;
        public static void Activate()
        {
            StardewValley.Tools.FishingRod.baseChanceForTreasure *= pirateTreasureChanceMultiplyer;
        }

        public static void Disable()
        {
            StardewValley.Tools.FishingRod.baseChanceForTreasure /= pirateTreasureChanceMultiplyer;
        }
    }
}
