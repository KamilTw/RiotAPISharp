using RiotAPISharp.Model.TFTMatchV1;
using RiotAPISharp.Utilities;
using System.Collections.Generic;

namespace RiotAPISharp.Endpoints.Interfaces
{
    public interface ITFTMatchV1
    {
        public IEnumerable<string> GetMatchesByPuuid(Region region, string puuid, int count = 20);

        public MatchDTO GetMatchesByMatchId(Region region, string matchId);
    }
}
