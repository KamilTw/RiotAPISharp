using System.Collections.Generic;

namespace RiotAPISharp.Model.LOLStatusV3
{
    public class ShardStatus
    {
        public IEnumerable<string> Locales { get; set; }

        public string Hostname { get; set; }

        public string Name { get; set; }

        public IEnumerable<Service> Services { get; set; }

        public string Slug { get; set; }

        public string Region_tag { get; set; }
    }
}
