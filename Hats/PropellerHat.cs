namespace DeluxeHats.Hats
{
    public static class PropellerHat
    {
        public const string Name = "Propeller Hat";
        public const string Description = "No effect.";

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("propeller-hat.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("propeller-hat.description");

        public static void Activate()
        {
        }

        public static void Disable()
        {
        }
    }
}
