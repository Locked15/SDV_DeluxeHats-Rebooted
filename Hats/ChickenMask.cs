namespace DeluxeHats.Hats
{
    public static class ChickenMask
    {
        public const string Name = "Chicken Mask";
        public const string Description = "No effect.";

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("chicken-mask.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("chicken-mask.description");

        public static void Activate()
        {
        }

        public static void Disable()
        {
        }
    }
}
