using RiotAPISharp.Endpoints.Implementations;
using RiotAPISharp.Endpoints.Interfaces;

namespace RiotAPISharp
{
    public class RiotAPI
    {
        public IAccountV1 AccountV1 { get; private set; }
        public IChampionMasteryV4 ChampionMasteryV4 { get; private set; }
        public IChampionV3 ChampionV3 { get; private set; }
        public IClashV1 ClashV1 { get; private set; }
        public ILeagueExpV4 LeagueExpV4 { get; private set; }
        public ILeagueV4 LeagueV4 { get; private set; }
        public ILOLStatusV3 LOLStatusV3 { get; private set; }
        public ILORRankedV1 LORRankedV1 { get; private set; }
        public IMatchV4 MatchV4 { get; private set; }
        public ISpectatorV4 SpectatorV4 { get; private set; }
        public ISummonerV4 SummonerV4 { get; private set; }
        public ITFTLeagueV1 TFTLeagueV1 { get; private set; }
        public ITFTMatchV1 TFTMatchV1 { get; private set; }
        public ITFTSummonerV1 TFTSummonerV1 { get; private set; }      

        public RiotAPI(string key)
        {
            AccountV1 = new AccountV1(key);
            ChampionMasteryV4 = new ChampionMasteryV4(key);
            ChampionV3 = new ChampionV3(key);
            ClashV1 = new ClashV1(key);
            LeagueExpV4 = new LeagueExpV4(key);
            LeagueV4 = new LeagueV4(key);
            LOLStatusV3 = new LOLStatusV3(key);
            LORRankedV1 = new LORRankedV1(key);
            MatchV4 = new MatchV4(key);
            SpectatorV4 = new SpectatorV4(key);
            SummonerV4 = new SummonerV4(key);
            TFTLeagueV1 = new TFTLeagueV1(key);
            TFTMatchV1 = new TFTMatchV1(key);
            TFTSummonerV1 = new TFTSummonerV1(key);
        }
    }
}
