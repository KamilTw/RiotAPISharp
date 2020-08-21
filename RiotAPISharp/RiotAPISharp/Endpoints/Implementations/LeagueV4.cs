using RiotAPISharp.Endpoints.Interfaces;
using RiotAPISharp.Model.LeagueV4;
using RiotAPISharp.Utilities;
using System.Collections.Generic;

namespace RiotAPISharp.Endpoints.Implementations
{
    public class LeagueV4 : EndpointBase, ILeagueV4
    {
        private const string challengerLeaguesByQueueUrl = "{0}/lol/league/v4/challengerleagues/by-queue/{1}";
        private const string entriesBySummonerIdUrl = "{0}/lol/league/v4/entries/by-summoner/{1}";
        private const string entriesByQueueTierAndDivisionUrl = "{0}/lol/league/v4/entries/{1}/{2}/{3}?page={4}";
        private const string grandmasterLeaguesByQueueUrl = "{0}/lol/league/v4/grandmasterleagues/by-queue/{1}";
        private const string leagueUrl = "{0}/lol/league/v4/leagues/{1}";
        private const string masterLeaguesUrl = "{0}/lol/league/v4/masterleagues/by-queue/{1}";

        public LeagueV4(string key) : base(key)
        {

        }

        public LeagueListDTO GetChallengerLeaguesByQueue(Platform platform, Queue queue)
        {
            string url = string.Format(challengerLeaguesByQueueUrl, platform.ToString(), queue.ToString());

            return GetObjectOfType<LeagueListDTO>(url);
        }

        public IEnumerable<LeagueEntryDTO> GetEntriesBySummonerId(Platform platform, string summonerId)
        {
            string url = string.Format(entriesBySummonerIdUrl, platform.ToString(), summonerId);

            return GetObjectOfType<IEnumerable<LeagueEntryDTO>>(url);
        }

        public IEnumerable<LeagueEntryDTO> GetEntriesByQueueTierAndDivision(Platform platform, Division division, Tier tier, Queue queue, int page = 1)
        {
            string url = string.Format(entriesByQueueTierAndDivisionUrl, platform.ToString(), queue.ToString(), tier.ToString(), division.ToString(), page);

            return GetObjectOfType<IEnumerable<LeagueEntryDTO>>(url);
        }

        public LeagueListDTO GetGrandmasterLeaguesByQueue(Platform platform, Queue queue)
        {
            string url = string.Format(grandmasterLeaguesByQueueUrl, platform.ToString(), queue.ToString());

            return GetObjectOfType<LeagueListDTO>(url);
        }

        public LeagueListDTO GetLeagues(Platform platform, string leagueId)
        {
            string url = string.Format(leagueUrl, platform.ToString(), leagueId);

            return GetObjectOfType<LeagueListDTO>(url);
        }

        public LeagueListDTO GetMasterLeagues(Platform platform, Queue queue)
        {
            string url = string.Format(masterLeaguesUrl, platform.ToString(), queue);

            return GetObjectOfType<LeagueListDTO>(url);
        }
    }
}