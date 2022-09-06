namespace DeluxeHats.Hats
{
    public static class FloppyBeanie
    {
        public const string Name = "Floppy Beanie";
        public const string Description = "No effect.";

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("floppy-beanie.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("floppy-beanie.description");

        public static void Activate()
        {
        }

        public static void Disable()
        {
        }
    }
}
