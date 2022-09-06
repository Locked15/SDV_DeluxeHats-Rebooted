namespace DeluxeHats.Hats
{
    public static class MagicTurban
    {
        public const string Name = "Magic Turban";
        public const string Description = "No effect.";

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("magic-turban.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("magic-turban.description");

        public static void Activate()
        {
        }

        public static void Disable()
        {
        }
    }
}
