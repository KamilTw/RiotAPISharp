using System.Collections.Generic;

namespace RiotAPISharp.Model.LOLStatusV3
{
    public class Incident
    {
        public bool Active { get; set; }

        public string Created_at { get; set; }

        public long Id { get; set; }

        public IEnumerable<Message> Updates { get; set; }
    }
}