using RiotAPISharp.Endpoints.Interfaces;
using RiotAPISharp.Model.TFTMatchV1;
using RiotAPISharp.Utilities;
using System.Collections.Generic;

namespace RiotAPISharp.Endpoints.Implementations
{
    public class TFTMatchV1 : EndpointBase, ITFTMatchV1
    {
        private const string matchesByPuuidUrl = "{0}/tft/match/v1/matches/by-puuid/{1}/ids?count={2}";
        private const string matchesByMatchIdUrl = "{0}/tft/match/v1/matches/{1}";

        public TFTMatchV1(string key) : base(key)
        {

        }

        public IEnumerable<string> GetMatchesByPuuid(Region region, string puuid, int count = 20)
        {
            string url = string.Format(matchesByPuuidUrl, region.ToString(), puuid, count);

            return GetObjectOfType<IEnumerable<string>>(url);
        }

        public MatchDTO GetMatchesByMatchId(Region region, string matchId)
        {
            string url = string.Format(matchesByMatchIdUrl, region.ToString(), matchId);

            return GetObjectOfType<MatchDTO>(url);
        }     
    }
}
