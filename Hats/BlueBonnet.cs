namespace DeluxeHats.Hats
{
    public static class BlueBonnet
    {
        public const string Name = "Blue Bonnet";
        public const string Description = "No effect.";

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("blue-bonnet.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("blue-bonnet.description");

        public static void Activate()
        {
        }

        public static void Disable()
        {
        }
    }
}
