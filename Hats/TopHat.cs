namespace DeluxeHats.Hats
{
    public static class TopHat
    {
        public const string Name = "Top Hat";
        public const string Description = "No effect.";

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("top-hat.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("top-hat.description");

        public static void Activate()
        {
        }

        public static void Disable()
        {
        }
    }
}
