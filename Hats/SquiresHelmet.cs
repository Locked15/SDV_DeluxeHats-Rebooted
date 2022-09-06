using StardewValley;

namespace DeluxeHats.Hats
{
    public static class SquiresHelmet
    {
        public const string Name = "Squire's Helmet";
        public const string Description = "Gain +2 armour and +2 attack";
        private const int squiresResilience = 2;
        private const int squiresAttack = 2;

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("squire's-helmet.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("squire's-helmet.description");

        public static void Activate()
        {
            Game1.player.resilience += squiresResilience;
            Game1.player.attackIncreaseModifier += squiresAttack;
        }

        public static void Disable()
        {
            Game1.player.resilience -= squiresResilience;
            Game1.player.attackIncreaseModifier -= squiresAttack;
        }
    }
}
