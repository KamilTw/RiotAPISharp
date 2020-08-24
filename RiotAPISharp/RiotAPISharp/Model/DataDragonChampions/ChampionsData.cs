using System.Collections.Generic;

namespace RiotAPISharp.Model.DataDragonChampions
{
    public class ChampionsData
    {
        public string Type { get; set; }

        public string Format { get; set; }

        public string Version { get; set; }

        public IDictionary<string, ChampionData> Data { get; set; }
    }
}
