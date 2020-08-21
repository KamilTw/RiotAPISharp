using RiotAPISharp.Model.LeagueV4;
using System.Collections.Generic;
using RiotAPISharp.Utilities;

namespace RiotAPISharp.Endpoints.Interfaces
{
    public interface ILeagueExpV4
    {
        public IEnumerable<LeagueEntryDTO> GetEntriesByQueueTierAndDivision(Platform platform, Queue queue, Tier tier, Division division, int page = 1);
    }
}