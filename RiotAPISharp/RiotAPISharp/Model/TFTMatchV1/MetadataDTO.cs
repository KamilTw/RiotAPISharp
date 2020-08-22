using System.Collections.Generic;

namespace RiotAPISharp.Model.TFTMatchV1
{
    public class MetadataDTO
    {
        public string Data_version { get; set; }

        public string Match_id { get; set; }

        public IEnumerable<string> Participants { get; set; }
    }
}