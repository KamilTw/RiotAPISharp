using RiotAPISharp.Endpoints.Interfaces;
using RiotAPISharp.Model.ChampionV3;
using RiotAPISharp.Utilities;

namespace RiotAPISharp.Endpoints.Implementations
{
    public class ChampionV3 : EndpointBase, IChampionV3
    {
        private const string championRotationsUrl = "{0}/lol/platform/v3/champion-rotations";

        public ChampionV3(string key) : base(key)
        {

        }

        public ChampionInfo GetChampionRotations(Platform platform)
        {
            string url = string.Format(championRotationsUrl, platform.ToString());

            return GetObjectOfType<ChampionInfo>(url);
        }
    }
}
