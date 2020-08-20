using RiotAPISharp.Model.ChampionV3;
using RiotAPISharp.Utilities;

namespace RiotAPISharp.Endpoints.Interfaces
{
    public interface IChampionV3
    {
        public ChampionInfo GetChampionRotations(Platform platform);
    }
}