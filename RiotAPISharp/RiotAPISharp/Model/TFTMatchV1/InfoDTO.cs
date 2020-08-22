using System.Collections.Generic;

namespace RiotAPISharp.Model.TFTMatchV1
{
    public class InfoDTO
    {
        public long Game_datetime { get; set; }

        public float Game_length { get; set; }

        public string Game_variation { get; set; }

        public string Game_version { get; set; }

        public IEnumerable<ParticipantDTO> Participants { get; set; }

        public int Queue_id { get; set; }

        public int Tft_set_number { get; set; }
    }
}