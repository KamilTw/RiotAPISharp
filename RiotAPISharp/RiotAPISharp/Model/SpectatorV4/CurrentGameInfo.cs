using System.Collections.Generic;

namespace RiotAPISharp.Model.SpectatorV4
{
    public class CurrentGameInfo
    {
        public long GameId { get; set; }

        public string GameType { get; set; }

        public long GameStartTime { get; set; }

        public long MapId { get; set; }

        public long GameLength { get; set; }

        public string PlatformId { get; set; }

        public string GameMode { get; set; }

        public IEnumerable<BannedChampion> BannedChampions { get; set; }

        public long GameQueueConfigId { get; set; }

        public Observer Observers { get; set; }

        public IEnumerable<CurrentGameParticipant> Participants { get; set; }
    }
}
