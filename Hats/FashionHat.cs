namespace DeluxeHats.Hats
{
    public static class FashionHat
    {
        public const string Name = "Fashion Hat";
        public const string Description = "No effect.";

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("fashion-hat.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("fashion-hat.description");

        public static void Activate()
        {
        }

        public static void Disable()
        {
        }
    }
}
