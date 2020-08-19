using System.Threading.Tasks;

namespace RiotAPISharp.Http
{
    public interface IRequester
    {
        public Task<string> CreateGetRequest(string url);
    }
}