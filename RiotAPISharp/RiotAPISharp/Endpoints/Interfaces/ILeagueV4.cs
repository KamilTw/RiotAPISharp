using RiotAPISharp.Model.LeagueV4;
using RiotAPISharp.Utilities;
using System.Collections.Generic;

namespace RiotAPISharp.Endpoints.Interfaces
{
    public interface ILeagueV4
    {
        public LeagueListDTO GetChallengerLeaguesByQueue(Platform platform, Queue queue);

        public IEnumerable<LeagueEntryDTO> GetEntriesByQueueTierAndDivision(Platform platform, Division division, Tier tier, Queue queue, int page = 1);

        public IEnumerable<LeagueEntryDTO> GetEntriesBySummonerId(Platform platform, string summonerId);

        public LeagueListDTO GetGrandmasterLeaguesByQueue(Platform platform, Queue queue);

        public LeagueListDTO GetLeagues(Platform platform, string leagueId);

        public LeagueListDTO GetMasterLeagues(Platform platform, Queue queue);
    }
}