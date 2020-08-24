using RiotAPISharp.Endpoints.Interfaces;
using RiotAPISharp.Model.DataDragonChampions;
using RiotAPISharp.Utilities;

namespace RiotAPISharp.Endpoints.Implementations
{
    public class DataDragonChampions : EndpointBase, IDataDragonChampions
    {
        private const string championsDataUrl = "ddragon.leagueoflegends.com/cdn/{0}/data/{1}/champion.json";   

        public ChampionsData GetChampionsData(string patchNumber, Language language)
        {
            string url = string.Format(championsDataUrl, patchNumber, language.ToString());

            return GetObjectOfType<ChampionsData>(url);
        }
    }
}
