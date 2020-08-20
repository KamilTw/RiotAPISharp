using RiotAPISharp.Model.ChampionMasteryV4;
using RiotAPISharp.Utilities;
using System.Collections.Generic;

namespace RiotAPISharp.Endpoints.Interfaces
{
    public interface IChampionMasteryV4
    {
        public IEnumerable<ChampionMasteryDTO> GetChampionMasteryBySummonerId(Platform platform, string summonerId);

        public ChampionMasteryDTO GetChampionMasteryBySummonerIdAndChampionId(Platform platform, string championId, string summonerId);

        public int GetTotalChampionMasteryScoreBySummonerId(Platform platform, string summonerId);
    }
}
