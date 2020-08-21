using System.Collections.Generic;

namespace RiotAPISharp.Model.LORRankedV1
{
    public class LeaderboardsDTO
    {
        public IEnumerable<PlayerDTO> Players { get; set; }
    }
}
