using RiotAPISharp.Model.LeagueV4;
using RiotAPISharp.Utilities;
using System.Collections.Generic;

namespace RiotAPISharp.Endpoints.Interfaces
{
    public interface ITFTLeagueV1
    {
        public LeagueListDTO GetChallenger(Platform platform);

        public IEnumerable<LeagueEntryDTO> GetEntriesBySummonerId(Platform platform, string summonerId);

        public IEnumerable<LeagueEntryDTO> GetEntriesByTierAndDivision(Platform platform, Tier tier, Division division, int page = 1);

        public LeagueListDTO GetGrandmaster(Platform platform);

        public LeagueListDTO GetLeaguesByLeagueId(Platform platform, string leagueId);

        public LeagueListDTO GetMaster(Platform platform);
    }
}
