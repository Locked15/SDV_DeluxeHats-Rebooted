namespace DeluxeHats.Hats
{
    public static class FlatToppedHat
    {
        public const string Name = "Flat Topped Hat";
        public const string Description = "No effect.";

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("flat-topped-hat.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("flat-topped-hat.description");

        public static void Activate()
        {
        }

        public static void Disable()
        {
        }
    }
}
