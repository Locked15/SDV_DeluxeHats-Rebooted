namespace DeluxeHats.Hats
{
    public static class Daisy
    {
        public const string Name = "Daisy";
        public const string Description = "No effect.";

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("daisy.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("daisy.description");

        public static void Activate()
        {
        }

        public static void Disable()
        {
        }
    }
}
