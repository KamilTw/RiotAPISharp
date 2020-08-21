using System.Collections.Generic;

namespace RiotAPISharp.Model.MatchV4
{
    public class ParticipantTimelineDTO
    {
        public int ParticipantId { get; set; }

        public IDictionary<string, double> CsDiffPerMinDeltas { get; set; }

        public IDictionary<string, double> DamageTakenPerMinDeltas { get; set; }

        public string Role { get; set; }

        public IDictionary<string, double> DamageTakenDiffPerMinDeltas { get; set; }

        public IDictionary<string, double> keyValuePairs { get; set; }

        public IDictionary<string, double> XpDiffPerMinDeltas { get; set; }

        public string Lane { get; set; }

        public IDictionary<string, double> CreepsPerMinDeltas { get; set; }

        public IDictionary<string, double> GoldPerMinDeltas { get; set; }
    }
}