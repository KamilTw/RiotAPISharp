using RiotAPISharp.Endpoints.Interfaces;
using RiotAPISharp.Model.ChampionMasteryV4;
using RiotAPISharp.Utilities;
using System.Collections.Generic;

namespace RiotAPISharp.Endpoints.Implementations
{
    public class ChampionMasteryV4 : EndpointBase, IChampionMasteryV4
    {
        private const string championMasteryBySummonerIdUrl = "{0}/lol/champion-mastery/v4/champion-masteries/by-summoner/{1}";
        private const string championMasteryChampionIdIdUrl = "{0}/lol/champion-mastery/v4/champion-masteries/by-summoner/{1}/by-champion/{2}";
        private const string totalChampionMasteryScoreBySummonerIdUrl = "{0}/lol/champion-mastery/v4/scores/by-summoner/{1}";


        public ChampionMasteryV4(string key) : base(key)
        {

        }

        public IEnumerable<ChampionMasteryDTO> GetChampionMasteryBySummonerId(Platform platform, string summonerId)
        {
            string url = string.Format(championMasteryBySummonerIdUrl, platform.ToString(), summonerId);

            return GetObjectOfType<IEnumerable<ChampionMasteryDTO>>(url);
        }

        public ChampionMasteryDTO GetChampionMasteryBySummonerIdAndChampionId(Platform platform, string championId, string summonerId)
        {
            string url = string.Format(championMasteryChampionIdIdUrl, platform.ToString(), summonerId, championId);

            return GetObjectOfType<ChampionMasteryDTO>(url);
        }

        public int GetTotalChampionMasteryScoreBySummonerId(Platform platform, string summonerId)
        {
            string url = string.Format(totalChampionMasteryScoreBySummonerIdUrl, platform.ToString(), summonerId);

            return GetObjectOfType<int>(url);
        }
    }
}
