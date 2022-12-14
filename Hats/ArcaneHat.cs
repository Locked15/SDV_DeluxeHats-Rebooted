using StardewValley;

namespace DeluxeHats.Hats
{
    public static class ArcaneHat
    {
        public const string Name = "Arcane Hat";
        public const string Description = "Random chance to delay time.";
        private const double arcaneSetbackTimerChance = 0.0008f;

        public static string DisplayedName =>
                      HatService.Helper.Translation.Get("arcane-hat.name");

        public static string DisplayedDescription =>
                      HatService.Helper.Translation.Get("arcane-hat.description");

        public static void Activate()
        {
            HatService.OnUpdateTicked = (e) =>
            {
                if (Game1.player.hasMenuOpen || !Game1.player.canMove || !Game1.game1.IsActive)
                {
                    return;
                }
                if (Game1.random.NextDouble() < (arcaneSetbackTimerChance + (Game1.player.DailyLuck / 2000.0)))
                {
                    Game1.gameTimeInterval = 0;
                }
            };
        }

        public static void Disable()
        {
        }
    }
}
