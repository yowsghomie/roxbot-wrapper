using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace roxbot_wrapper.Utils
{
    public class Stats
    {
        public static string Url = "https://nigger.team/roxbot";

        public string GetRawResponse(string username)
        {
            string result = "";
            using (WebClient wc = new WebClient())
            {
                result = wc.DownloadString($"{Url}?username={username}");
            }
            return result;
        }

        public string GetStats(StatsType type, string username)
        {
            dynamic res = JsonConvert.DeserializeObject(GetRawResponse(username));
            string result = "";
            switch (type)
            {
                case StatsType.rank:
                    result = res.rank;
                    break;
                case StatsType.points:
                    result = res.points;
                    break;
                case StatsType.kills:
                    result = res.kills;
                    break;
                case StatsType.deaths:
                    result = res.deaths;
                    break;
                case StatsType.ratio:
                    result = res.ratio;
                    break;
                case StatsType.damage_taken:
                    result = res.damage_taken;
                    break;
                case StatsType.damage_dealt:
                    result = res.damage_dealt;
                    break;
                case StatsType.best_streak:
                    result = res.best_streak;
                    break;
                case StatsType.best_multi:
                    result = res.best_multi;
                    break;
                case StatsType.bow_accuracy:
                    result = res.bow_accuracy;
                    break;
                case StatsType.time_played:
                    result = res.time_played;
                    break;
            }

            return result;
        }
    }
}
