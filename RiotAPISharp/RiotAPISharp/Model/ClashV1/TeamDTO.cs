using System.Collections.Generic;

namespace RiotAPISharp.Model.ClashV1
{
    public class TeamDTO
    {
        public string Id { get; set; }

        public int TouramentId { get; set; }

        public string Name { get; set; }

        public int IconId { get; set; }

        public int Tier { get; set; }

        public string Captain { get; set; }

        public int MyProperty { get; set; }

        public string Abbreviation { get; set; }

        public IEnumerable<PlayerDTO> Players { get; set; }
    }
}
