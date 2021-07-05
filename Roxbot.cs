using RoxbotWrapper.Utils;

namespace RoxbotWrapper
{
    public class Roxbot
    {
        public static Stats s = new Stats();

        public static string GetRank(string username)
        {
            return s.GetStats(StatsType.rank, username);
        }

        public static string GetPoints(string username)
        {
            return s.GetStats(StatsType.points, username);
        }

        public static string GetKills(string username)
        {
            return s.GetStats(StatsType.kills, username);
        }

        public static string GetDeaths(string username)
        {
            return s.GetStats(StatsType.deaths, username);
        }

        public static string GetRatio(string username)
        {
            return s.GetStats(StatsType.ratio, username);
        }

        public static string GetDamageTaken(string username)
        {
            return s.GetStats(StatsType.damage_taken, username);
        }

        public static string GetDamageDealt(string username)
        {
            return s.GetStats(StatsType.rank, username);
        }

        public static string GetBestStreak(string username)
        {
            return s.GetStats(StatsType.best_streak, username);
        }

        public static string GetBestMulti(string username)
        {
            return s.GetStats(StatsType.best_multi, username);
        }

        public static string GetBowAccuracy(string username)
        {
            return s.GetStats(StatsType.bow_accuracy, username);
        }

        public static string GetTimePlayed(string username)
        {
            return s.GetStats(StatsType.time_played, username);
        }
    }
}
