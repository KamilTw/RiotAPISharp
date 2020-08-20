using System.Collections.Generic;

namespace RiotAPISharp.Model.ChampionV3
{
    public class ChampionInfo
    {
        public int MaxNewPlayerLevel { get; set; }

        public IEnumerable<int> FreeChampionIdsForNewPlayers { get; set; }

        public IEnumerable<int> FreeChampionIds { get; set; }
    }
}
