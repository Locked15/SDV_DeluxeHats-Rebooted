namespace DeluxeHats.Hats
{
    public static class WatermelonBand
    {
        public const string Name = "Watermelon Band";
        public const string Description = "No effect.";

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("watermelon-band.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("watermelon-band.description");

        public static void Activate()
        {
        }

        public static void Disable()
        {
        }
    }
}
