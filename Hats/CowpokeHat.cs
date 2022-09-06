namespace DeluxeHats.Hats
{
    public static class CowpokeHat
    {
        public const string Name = "Cowpoke Hat";
        public const string Description = "No effect.";

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("cowpoke-hat.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("cowpoke-hat.description");

        public static void Activate()
        {
        }

        public static void Disable()
        {
        }
    }
}
