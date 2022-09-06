namespace DeluxeHats.Hats
{
    public static class DinosaurHat
    {
        public const string Name = "Dinosaur Hat";
        public const string Description = "No effect.";

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("dinosaur-hat.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("dinosaur-hat.description");

        public static void Activate()
        {
        }

        public static void Disable()
        {
        }
    }
}
