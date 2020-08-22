using System.Collections.Generic;

namespace RiotAPISharp.Model.SpectatorV4
{
    public class FeaturedGames
    {
        public IEnumerable<FeaturedGameInfo> GameList { get; set; }

        public long ClientRefreshInterval { get; set; }
    }
}
