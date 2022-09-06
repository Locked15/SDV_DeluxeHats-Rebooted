namespace DeluxeHats.Hats
{
    public static class GoblinMask
    {
        public const string Name = "Goblin Mask";
        public const string Description = "No effect.";

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("goblin-mask.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("goblin-mask.description");

        public static void Activate()
        {
        }

        public static void Disable()
        {
        }
    }
}
