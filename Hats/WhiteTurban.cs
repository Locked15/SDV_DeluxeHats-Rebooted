namespace DeluxeHats.Hats
{
    public static class WhiteTurban
    {
        public const string Name = "White Turban";
        public const string Description = "No effect.";

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("white-turban.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("white-turban.description");

        public static void Activate()
        {
        }

        public static void Disable()
        {
        }
    }
}
