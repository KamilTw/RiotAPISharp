using RiotAPISharp.Endpoints.Interfaces;
using RiotAPISharp.Model.LeagueV4;
using RiotAPISharp.Utilities;
using System.Collections.Generic;

namespace RiotAPISharp.Endpoints.Implementations
{
    public class TFTLeagueV1 : EndpointBase, ITFTLeagueV1
    {
        private const string challengerUrl = "{0}/tft/league/v1/challenger";
        private const string entriesBySummonerIdUrl = "{0}/tft/league/v1/entries/by-summoner/{1}";
        private const string entriesByTierAndDivisionUrl = "{0}/tft/league/v1/entries/{1}/{2}?page={3}";
        private const string grandmasterUrl = "{0}/tft/league/v1/grandmaster";
        private const string leaguesByLeagueIdUrl = "{0}/tft/league/v1/leagues/{1}";
        private const string masterUrl = "{0}/tft/league/v1/master";

        public TFTLeagueV1(string key) : base(key)
        {

        }

        public LeagueListDTO GetChallenger(Platform platform)
        {
            string url = string.Format(challengerUrl, platform.ToString());

            return GetObjectOfType<LeagueListDTO>(url);
        }

        public IEnumerable<LeagueEntryDTO> GetEntriesBySummonerId(Platform platform, string summonerId)
        {
            string url = string.Format(entriesBySummonerIdUrl, platform.ToString(), summonerId);

            return GetObjectOfType<IEnumerable<LeagueEntryDTO>>(url);
        }

        public IEnumerable<LeagueEntryDTO> GetEntriesByTierAndDivision(Platform platform, Tier tier, Division division, int page = 1)
        {
            string url = string.Format(entriesByTierAndDivisionUrl, platform.ToString(), tier.ToString(), division.ToString(), page);

            return GetObjectOfType<IEnumerable<LeagueEntryDTO>>(url);
        }

        public LeagueListDTO GetGrandmaster(Platform platform)
        {
            string url = string.Format(grandmasterUrl, platform.ToString());

            return GetObjectOfType<LeagueListDTO>(url);
        }

        public LeagueListDTO GetLeaguesByLeagueId(Platform platform, string leagueId)
        {
            string url = string.Format(leaguesByLeagueIdUrl, platform.ToString(), leagueId);

            return GetObjectOfType<LeagueListDTO>(url);
        }

        public LeagueListDTO GetMaster(Platform platform)
        {
            string url = string.Format(masterUrl, platform.ToString());

            return GetObjectOfType<LeagueListDTO>(url);
        }
    }
}
