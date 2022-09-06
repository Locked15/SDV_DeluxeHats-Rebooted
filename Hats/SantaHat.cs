namespace DeluxeHats.Hats
{
    public static class SantaHat
    {
        public const string Name = "Santa Hat";
        public const string Description = "No effect.";

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("santa-hat.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("santa-hat.description");

        public static void Activate()
        {
        }

        public static void Disable()
        {
        }
    }
}
