using System.Collections.Generic;

namespace RiotAPISharp.Model.MatchV4
{
    public class MatchTimelineDTO
    {
        public IEnumerable<MatchFrameDTO> Frames { get; set; }

        public long FrameInterval { get; set; }
    }
}
