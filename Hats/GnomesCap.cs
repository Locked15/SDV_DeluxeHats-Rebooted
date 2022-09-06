namespace DeluxeHats.Hats
{
    public static class GnomesCap
    {
        public const string Name = "Gnome's Cap";
        public const string Description = "No effect.";

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("gnome's-cap.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("gnome's-hat.description");

        public static void Activate()
        {
        }

        public static void Disable()
        {
        }
    }
}
