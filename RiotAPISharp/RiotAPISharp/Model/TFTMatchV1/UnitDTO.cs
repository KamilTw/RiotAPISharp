using System.Collections.Generic;

namespace RiotAPISharp.Model.TFTMatchV1
{
    public class UnitDTO
    {
        public IEnumerable<int> Items { get; set; }

        public string Character_id { get; set; }

        public string Name { get; set; }

        public int Rarity { get; set; }

        public int Tier { get; set; }
    }
}