namespace DeluxeHats.Hats
{
    public static class LivingHat
    {
        public const string Name = "Living Hat";
        public const string Description = "No effect.";

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("living-hat.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("living-hat.description");

        public static void Activate()
        {
        }

        public static void Disable()
        {
        }
    }
}
