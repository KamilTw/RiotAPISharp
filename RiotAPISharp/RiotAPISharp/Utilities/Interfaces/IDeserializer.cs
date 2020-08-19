namespace RiotAPISharp.Utilities.Interfaces
{
    public interface IDeserializer
    {
        public T DeserializeObject<T>(string responseBody);
    }
}