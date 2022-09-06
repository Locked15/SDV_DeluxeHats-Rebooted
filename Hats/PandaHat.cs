namespace DeluxeHats.Hats
{
    public static class PandaHat
    {
        public const string Name = "Panda Hat";
        public const string Description = "No effect.";

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("panda-hat.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("panda-hat.description");

        public static void Activate()
        {
        }

        public static void Disable()
        {
        }
    }
}
