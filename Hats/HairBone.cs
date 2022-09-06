namespace DeluxeHats.Hats
{
    public static class HairBone
    {
        public const string Name = "Hair Bone";
        public const string Description = "No effect.";

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("hair-bone.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("hair-bone.description");

        public static void Activate()
        {
        }

        public static void Disable()
        {
        }
    }
}
