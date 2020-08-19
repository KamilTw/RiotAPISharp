using Newtonsoft.Json;
using RiotAPISharp.Utilities.Interfaces;

namespace RiotAPISharp.Utilities
{
    public class Deserializer : IDeserializer
    {
        public T DeserializeObject<T>(string responseBody)
        {
            T model = JsonConvert.DeserializeObject<T>(responseBody);

            return model;
        }
    }
}
