using RiotAPISharp.Endpoints.Interfaces;
using RiotAPISharp.Model.LOLStatusV3;
using RiotAPISharp.Utilities;

namespace RiotAPISharp.Endpoints.Implementations
{
    public class LOLStatusV3 : EndpointBase, ILOLStatusV3
    {
        private const string shardDataUrl = "{0}/lol/status/v3/shard-data";

        public LOLStatusV3(string key) : base(key)
        {

        }

        public ShardStatus GetShardData(Platform platform)
        {
            string url = string.Format(shardDataUrl, platform.ToString());

            return GetObjectOfType<ShardStatus>(url);
        }
    }
}
