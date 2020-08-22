using RiotAPISharp.Endpoints.Interfaces;
using RiotAPISharp.Model.SpectatorV4;
using RiotAPISharp.Utilities;

namespace RiotAPISharp.Endpoints.Implementations
{
    public class SpectatorV4 : EndpointBase, ISpectatorV4
    {
        private const string activeGamesBySummonerIdUrl = "{0}/lol/spectator/v4/active-games/by-summoner/{1}";
        private const string featuredGamesUrl = "{0}/lol/spectator/v4/featured-games";


        public SpectatorV4(string key) : base(key)
        {

        }

        public CurrentGameInfo GetActiveGamesBySummonerId(Platform platform, string summonerId)
        {
            string url = string.Format(activeGamesBySummonerIdUrl, platform.ToString(), summonerId);

            return GetObjectOfType<CurrentGameInfo>(url);
        }

        public FeaturedGames GetFeaturedGames(Platform platform)
        {
            string url = string.Format(featuredGamesUrl, platform.ToString());

            return GetObjectOfType<FeaturedGames>(url);
        }
    }
}