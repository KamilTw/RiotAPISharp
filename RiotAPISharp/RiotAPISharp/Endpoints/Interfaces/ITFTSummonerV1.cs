using RiotAPISharp.Model.SummonerV4;
using RiotAPISharp.Utilities;

namespace RiotAPISharp.Endpoints.Interfaces
{
    public interface ITFTSummonerV1
    {
        public SummonerDTO GetSummonersByAccountId(Platform platform, string accountId);

        public SummonerDTO GetSummonersByName(Platform platform, string name);

        public SummonerDTO GetSummonersByPuuid(Platform platform, string puuid);

        public SummonerDTO GetSummonersById(Platform platform, string id);
    }
}
