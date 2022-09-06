namespace DeluxeHats.Hats
{
    public static class GreenTurban
    {
        public const string Name = "Green Turban";
        public const string Description = "No effect.";

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("green-turban.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("green-turban.description");

        public static void Activate()
        {
        }

        public static void Disable()
        {
        }
    }
}
