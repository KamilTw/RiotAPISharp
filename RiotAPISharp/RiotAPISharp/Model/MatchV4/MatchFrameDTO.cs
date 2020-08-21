using System.Collections.Generic;

namespace RiotAPISharp.Model.MatchV4
{
    public class MatchFrameDTO
    {
        public IDictionary<string, MatchParticipantFrameDTO> ParticipantFrames { get; set; }

        public IEnumerable<MatchEventDTO> Events { get; set; }

        public long Timestamp { get; set; }
    }
}