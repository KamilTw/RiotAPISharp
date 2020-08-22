using RiotAPISharp.Model.SpectatorV4;
using RiotAPISharp.Utilities;

namespace RiotAPISharp.Endpoints.Interfaces
{
    public interface ISpectatorV4
    {
        public CurrentGameInfo GetActiveGamesBySummonerId(Platform platform, string summonerId);

        public FeaturedGames GetFeaturedGames(Platform platform);
    }
}