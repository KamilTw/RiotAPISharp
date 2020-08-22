using RiotAPISharp.Endpoints.Interfaces;
using RiotAPISharp.Model.SummonerV4;
using RiotAPISharp.Utilities;
using System;

namespace RiotAPISharp.Endpoints.Implementations
{
    public class TFTSummonerV1 : EndpointBase, ITFTSummonerV1
    {
        private const string summonersByAccountIdUrl = "{0}/tft/summoner/v1/summoners/by-account/{1}";
        private const string summonersByNameUrl = "{0}/tft/summoner/v1/summoners/by-name/{1}";
        private const string summonersByPuuidUrl = "{0}/tft/summoner/v1/summoners/by-puuid/{1}";
        private const string summonersByIdUrl = "{0}/tft/summoner/v1/summoners/{1}";

        public TFTSummonerV1(string key) : base(key)
        {

        }

        public SummonerDTO GetSummonersByAccountId(Platform platform, string accountId)
        {
            string url = string.Format(summonersByAccountIdUrl, platform.ToString(), accountId);

            return GetObjectOfType<SummonerDTO>(url);
        }

        public SummonerDTO GetSummonersByName(Platform platform, string name)
        {
            string url = string.Format(summonersByNameUrl, platform.ToString(), name);

            return GetObjectOfType<SummonerDTO>(url);
        }

        public SummonerDTO GetSummonersByPuuid(Platform platform, string puuid)
        {
            string url = string.Format(summonersByPuuidUrl, platform.ToString(), puuid);

            return GetObjectOfType<SummonerDTO>(url);
        }

        public SummonerDTO GetSummonersById(Platform platform, string id)
        {
            string url = string.Format(summonersByIdUrl, platform.ToString(), id);

            return GetObjectOfType<SummonerDTO>(url);
        }   
    }
}
