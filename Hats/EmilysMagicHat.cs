namespace DeluxeHats.Hats
{
    public static class EmilysMagicHat
    {
        public const string Name = "Emily's Magic Hat";
        public const string Description = "No effect.";

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("emily's-magic-hat.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("emily's-magic-hat.description");

        public static void Activate()
        {
        }

        public static void Disable()
        {
        }
    }
}
