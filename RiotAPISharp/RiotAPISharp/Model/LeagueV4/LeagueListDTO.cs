using System.Collections.Generic;

namespace RiotAPISharp.Model.LeagueV4
{
    public class LeagueListDTO
    {
        public string LeagueId { get; set; }

        public IEnumerable<LeagueItemDTO> Entries { get; set; }

        public string Tier { get; set; }

        public string Name { get; set; }

        public string Queue { get; set; }
    }
}
