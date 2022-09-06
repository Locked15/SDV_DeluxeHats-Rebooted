namespace DeluxeHats.Hats
{
    public static class GarbageHat
    {
        public const string Name = "Garbage Hat";
        public const string Description = "No effect.";

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("garbage-hat.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("garbage-hat.description");

        public static void Activate()
        {
        }

        public static void Disable()
        {
        }
    }
}
