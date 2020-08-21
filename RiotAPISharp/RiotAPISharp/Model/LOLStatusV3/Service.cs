using System.Collections.Generic;

namespace RiotAPISharp.Model.LOLStatusV3
{
    public class Service
    {
        public IEnumerable<Incident> Incidents { get; set; }

        public string Name { get; set; }

        public string Slug { get; set; }

        public string Status { get; set; }
    }
}