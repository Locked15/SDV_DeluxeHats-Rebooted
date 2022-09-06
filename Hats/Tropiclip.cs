namespace DeluxeHats.Hats
{
    public static class Tropiclip
    {
        public const string Name = "Tropiclip";
        public const string Description = "No effect.";

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("tropiclip.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("tropiclip.description");

        public static void Activate()
        {
        }

        public static void Disable()
        {
        }
    }
}
