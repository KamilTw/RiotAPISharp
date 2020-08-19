using RiotAPISharp.Endpoints.Interfaces;
using RiotAPISharp.Model.AccountV1;
using RiotAPISharp.Utilities;

namespace RiotAPISharp.Endpoints.Implementations
{
    public class AccountV1 : EndpointBase, IAccountV1
    {
        private const string accountsByPuuidUrl = "{0}/riot/account/v1/accounts/by-puuid/{1}";

        public AccountV1(string key) : base(key)
        {

        }

        public AccountDTO GetAccountsByPuuid(Region region, string puuid)
        {
            string url = string.Format(accountsByPuuidUrl, region.ToString(), puuid);

            return GetObjectOfType<AccountDTO>(url);
        }
    }
}
