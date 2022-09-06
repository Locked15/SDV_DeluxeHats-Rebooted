namespace DeluxeHats.Hats
{
    public static class EyePatch
    {
        public const string Name = "Eye Patch";
        public const string Description = "No effect.";

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("eye-patch.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("eye-patch.description");

        public static void Activate()
        {
        }

        public static void Disable()
        {
        }
    }
}
