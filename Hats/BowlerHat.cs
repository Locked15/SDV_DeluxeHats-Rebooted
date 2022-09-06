namespace DeluxeHats.Hats
{
    public static class BowlerHat
    {
        public const string Name = "Bowler Hat";
        public const string Description = "No effect.";

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("bowler-hat.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("bowler-hat.description");

        public static void Activate()
        {
        }

        public static void Disable()
        {
        }
    }
}
