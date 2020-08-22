using System.Collections.Generic;

namespace RiotAPISharp.Model.SpectatorV4
{
    public class Perks
    {
        public IEnumerable<long> PerkIds { get; set; }

        public long PerkStyle { get; set; }

        public long PerkSubStyle { get; set; }
    }
}