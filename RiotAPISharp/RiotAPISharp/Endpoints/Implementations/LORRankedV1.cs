using RiotAPISharp.Endpoints.Interfaces;
using RiotAPISharp.Model.LORRankedV1;
using RiotAPISharp.Utilities;

namespace RiotAPISharp.Endpoints.Implementations
{
    public class LORRankedV1 : EndpointBase, ILORRankedV1
    {
        private const string accountsByPuuidUrl = "{0}/lor/ranked/v1/leaderboards";

        public LORRankedV1(string key) : base(key)
        {

        }

        public LeaderboardsDTO GetLeaderboards(Region region)
        {
            string url = string.Format(accountsByPuuidUrl, region.ToString());

            return GetObjectOfType<LeaderboardsDTO>(url);
        }
    }
}
