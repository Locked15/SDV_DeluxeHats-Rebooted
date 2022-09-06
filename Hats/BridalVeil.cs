namespace DeluxeHats.Hats
{
    public static class BridalVeil
    {
        public const string Name = "Bridal Veil";
        public const string Description = "No effect.";

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("bridal-veil.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("bridal-veil.description");

        public static void Activate()
        {
        }

        public static void Disable()
        {
        }
    }
}
