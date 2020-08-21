using RiotAPISharp.Model.LOLStatusV3;
using RiotAPISharp.Utilities;

namespace RiotAPISharp.Endpoints.Interfaces
{
    public interface ILOLStatusV3
    {
        public ShardStatus GetShardData(Platform platform);
    }
}