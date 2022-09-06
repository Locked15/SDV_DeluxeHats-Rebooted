namespace DeluxeHats.Hats
{
    public static class Sombrero
    {
        public const string Name = "Sombrero";
        public const string Description = "No effect.";

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("sombrero.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("sombrero.description");

        public static void Activate()
        {
        }

        public static void Disable()
        {
        }
    }
}
