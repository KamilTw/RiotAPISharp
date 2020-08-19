using RiotAPISharp.Http;
using RiotAPISharp.Utilities;
using RiotAPISharp.Utilities.Interfaces;

namespace RiotAPISharp.Endpoints.Implementations
{
    public abstract class EndpointBase
    {
        private IRequester Requester { get; set; }
        private IDeserializer Deserializer { get; set; }

        protected EndpointBase(string key)
        {
            Requester = new Requester(key);
            Deserializer = new Deserializer();
        }

        protected T GetObjectOfType<T>(string url)
        {
            string responseBody = Requester.CreateGetRequest(url).Result;

            if (responseBody != null)
            {
                T obj = Deserializer.DeserializeObject<T>(responseBody);

                return obj;
            }

            return default;
        }
    }
}
