namespace DeluxeHats.Hats
{
    public static class SpottedHeadscarf
    {
        public const string Name = "Spotted Headscarf";
        public const string Description = "No effect.";

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("spotted-headscarf.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("spotted-headscarf.description");

        public static void Activate()
        {
        }

        public static void Disable()
        {
        }
    }
}
