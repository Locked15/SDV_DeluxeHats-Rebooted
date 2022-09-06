namespace DeluxeHats.Hats
{
    public static class ElegantTurban
    {
        public const string Name = "Elegant Turban";
        public const string Description = "No effect.";

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("elegant-turban.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("elegant-turban.description");

        public static void Activate()
        {
        }

        public static void Disable()
        {
        }
    }
}
