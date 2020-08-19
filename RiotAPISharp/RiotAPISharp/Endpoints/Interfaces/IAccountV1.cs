using RiotAPISharp.Model.AccountV1;
using RiotAPISharp.Utilities;

namespace RiotAPISharp.Endpoints.Interfaces
{
    public interface IAccountV1
    {
        public AccountDTO GetAccountsByPuuid(Region region, string puuid);
    }
}