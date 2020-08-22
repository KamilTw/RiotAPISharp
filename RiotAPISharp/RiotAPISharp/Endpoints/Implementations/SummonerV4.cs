using RiotAPISharp.Endpoints.Interfaces;
using RiotAPISharp.Model.SummonerV4;
using RiotAPISharp.Utilities;

namespace RiotAPISharp.Endpoints.Implementations
{
    public class SummonerV4 : EndpointBase, ISummonerV4
    {
        private const string summonerByAccountIdUrl = "{0}/lol/summoner/v4/summoners/by-account/{1}";
        private const string summonerByNameUrl = "{0}/lol/summoner/v4/summoners/by-name/{1}";
        private const string summonerByPuuidIdUrl = "{0}/lol/summoner/v4/summoners/by-puuid/{1}";
        private const string summonerByIdUrl = "{0}/lol/summoner/v4/summoners/{1}";


        public SummonerV4(string key) : base(key)
        {

        }

        public SummonerDTO GetSummonersByAccountId(Platform platform, string accountId)
        {
            string url = string.Format(summonerByAccountIdUrl, platform.ToString(), accountId);

            return GetObjectOfType<SummonerDTO>(url);
        }

        public SummonerDTO GetSummonersByName(Platform platform, string name)
        {
            string url = string.Format(summonerByNameUrl, platform.ToString(), name);

            return GetObjectOfType<SummonerDTO>(url);
        }

        public SummonerDTO GetSummonersByPuuid(Platform platform, string puuidId)
        {
            string url = string.Format(summonerByPuuidIdUrl, platform.ToString(), puuidId);

            return GetObjectOfType<SummonerDTO>(url);
        }

        public SummonerDTO GetSummonersById(Platform platform, string id)
        {
            string url = string.Format(summonerByIdUrl, platform.ToString(), id);

            return GetObjectOfType<SummonerDTO>(url);
        }
    }
}
