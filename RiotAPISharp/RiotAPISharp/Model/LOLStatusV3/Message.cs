using System.Collections.Generic;

namespace RiotAPISharp.Model.LOLStatusV3
{
    public class Message
    {
        public string Severity { get; set; }

        public string Updated_at { get; set; }

        public string Author { get; set; }

        public IEnumerable<Translation> Translations { get; set; }

        public string Created_at { get; set; }

        public string Id { get; set; }

        public string Content { get; set; }
    }
}