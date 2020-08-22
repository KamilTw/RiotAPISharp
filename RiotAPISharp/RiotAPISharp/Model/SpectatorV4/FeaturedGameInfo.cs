using System.Collections.Generic;

namespace RiotAPISharp.Model.SpectatorV4
{
    public class FeaturedGameInfo
    {
        public string GameMode { get; set; }

        public long GameLength { get; set; }

        public long MapId { get; set; }

        public string GameType { get; set; }

        public IEnumerable<BannedChampion> BannedChampions { get; set; }

        public long GameId { get; set; }

        public Observer Observers { get; set; }

        public long GameQueueConfigId { get; set; }

        public long GameStartTime { get; set; }

        public IEnumerable<Participant> Participants { get; set; }

        public string PlatformId { get; set; }
    }
}