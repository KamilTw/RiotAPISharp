using RiotAPISharp.Model.DataDragonChampions;
using RiotAPISharp.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RiotAPISharp.Endpoints.Interfaces
{
    public interface IDataDragonChampions
    {
        public ChampionsData GetChampionsData(string patchNumber, Language language);
    }
}
