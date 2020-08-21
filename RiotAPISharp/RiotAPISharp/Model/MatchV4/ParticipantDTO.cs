using System.Collections.Generic;

namespace RiotAPISharp.Model.MatchV4
{
    public class ParticipantDTO
    {
        public int ParticipantId { get; set; }

        public int ChampionId { get; set; }

        public IEnumerable<RuneDTO> Runes { get; set; }

        public ParticipantStatsDTO Stats { get; set; }

        public int TeamsId { get; set; }

        public ParticipantTimelineDTO Timeline { get; set; }

        public int Spell1Id { get; set; }

        public int Spell2Id { get; set; }

        public string HighestAchievedSeasonTier { get; set; }

        public IEnumerable<MasteryDTO> Mastery { get; set; }


    }
}