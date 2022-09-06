namespace DeluxeHats.Hats
{
    public static class LogoCap
    {
        public const string Name = "Logo Cap";
        public const string Description = "No effect.";

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("logo-cap.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("logo-cap.description");

        public static void Activate()
        {
        }

        public static void Disable()
        {
        }
    }
}
