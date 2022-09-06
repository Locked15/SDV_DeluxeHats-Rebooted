namespace DeluxeHats.Hats
{
    public static class CopperPan
    {
        public const string Name = "Copper Pan";
        public const string Description = "No effect.";

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("copper-pan.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("copper-pan.description");

        public static void Activate()
        {
        }

        public static void Disable()
        {
        }
    }
}
