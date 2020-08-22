using RiotAPISharp.Model.SummonerV4;
using RiotAPISharp.Utilities;

namespace RiotAPISharp.Endpoints.Interfaces
{
    public interface ISummonerV4
    {
        public SummonerDTO GetSummonersByAccountId(Platform platform, string accountId);

        public SummonerDTO GetSummonersById(Platform platform, string id);

        public SummonerDTO GetSummonersByName(Platform platform, string name);

        public SummonerDTO GetSummonersByPuuid(Platform platform, string puuidId);
    }
}