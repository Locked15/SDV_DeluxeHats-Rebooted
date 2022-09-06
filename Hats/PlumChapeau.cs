namespace DeluxeHats.Hats
{
    public static class PlumChapeau
    {
        public const string Name = "Plum Chapeau";
        public const string Description = "No effect.";

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("plum-chapeau.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("plum-chapeau.description");

        public static void Activate()
        {
        }

        public static void Disable()
        {
        }
    }
}
