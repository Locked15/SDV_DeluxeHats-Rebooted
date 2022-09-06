namespace DeluxeHats.Hats
{
    public static class MushroomCap
    {
        public const string Name = "Mushroom Cap";
        public const string Description = "No effect.";

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("mushroom-cap.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("mushroom-cap.description");

        public static void Activate()
        {
        }

        public static void Disable()
        {
        }
    }
}
