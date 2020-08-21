using RiotAPISharp.Model.LORRankedV1;
using RiotAPISharp.Utilities;

namespace RiotAPISharp.Endpoints.Interfaces
{
    public interface ILORRankedV1
    {
        public LeaderboardsDTO GetLeaderboards(Region region);
    }
}
