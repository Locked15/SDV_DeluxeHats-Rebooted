namespace DeluxeHats.Hats
{
    public static class PolkaBow
    {
        public const string Name = "Polka Bow";
        public const string Description = "No effect.";

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("polka-bow.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("polka-bow.description");

        public static void Activate()
        {
        }

        public static void Disable()
        {
        }
    }
}
