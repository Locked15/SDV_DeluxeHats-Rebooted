namespace DeluxeHats.Hats
{
    public static class ConeHat
    {
        public const string Name = "Cone Hat";
        public const string Description = "No effect.";

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("cone-hat.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("cone-hat.description");

        public static void Activate()
        {
        }

        public static void Disable()
        {
        }
    }
}
