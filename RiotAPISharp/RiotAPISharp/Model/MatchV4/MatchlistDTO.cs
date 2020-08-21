using System.Collections.Generic;

namespace RiotAPISharp.Model.MatchV4
{
    public class MatchlistDTO
    {
        public int StartIndex { get; set; }

        public int TotalGames { get; set; }

        public int EndIndex { get; set; }

        public IEnumerable<MatchReferenceDTO> Matches { get; set; }
    }
}
