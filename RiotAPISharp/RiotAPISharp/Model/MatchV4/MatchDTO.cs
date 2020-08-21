using System.Collections.Generic;

namespace RiotAPISharp.Model.MatchV4
{
    public class MatchDTO
    {
        public long GameId { get; set; }

        public IEnumerable<ParticipantIdentityDTO> ParticipantIdentities { get; set; }

        public int QueueId { get; set; }

        public string GameType { get; set; }

        public long GameDuration { get; set; }

        public IEnumerable<TeamStatsDTO> Teams { get; set; }

        public string PlatformId { get; set; }

        public long GameCreation { get; set; }

        public int SeasonId { get; set; }

        public string GameVision { get; set; }

        public int MapId { get; set; }

        public string GameMode { get; set; }

        public IEnumerable<ParticipantDTO> Participants { get; set; }
    }
}
