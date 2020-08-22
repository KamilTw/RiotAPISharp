using System.Collections.Generic;

namespace RiotAPISharp.Model.TFTMatchV1
{
    public class ParticipantDTO
    {
        public CompanionDTO Companion { get; set; }

        public int Gold_left { get; set; }

        public int Last_round { get; set; }

        public int Level { get; set; }

        public int Placement { get; set; }

        public int Players_eliminated { get; set; }

        public string Puuid { get; set; }

        public float Time_eliminated { get; set; }

        public int Total_damage_to_players { get; set; }

        public IEnumerable<TraitDTO> Traits { get; set; }

        public IEnumerable<UnitDTO> Units { get; set; }
    }
}