using RiotAPISharp.Endpoints.Interfaces;
using RiotAPISharp.Model.LeagueV4;
using RiotAPISharp.Utilities;
using System.Collections.Generic;

namespace RiotAPISharp.Endpoints.Implementations
{
    public class LeagueExpV4 : EndpointBase, ILeagueExpV4
    {
        private const string entriesByQueueTierAndDivisionUrl = "{0}/lol/league-exp/v4/entries/{1}/{2}/{3}?page={4}";

        public LeagueExpV4(string key) : base(key)
        {

        }

        public IEnumerable<LeagueEntryDTO> GetEntriesByQueueTierAndDivision(Platform platform, Queue queue, Tier tier, Division division, int page = 1)
        {
            string url = string.Format(entriesByQueueTierAndDivisionUrl, platform.ToString(), queue.ToString(), tier.ToString(), division.ToString(), page);

            return GetObjectOfType<IEnumerable<LeagueEntryDTO>>(url);
        }
    }
}
