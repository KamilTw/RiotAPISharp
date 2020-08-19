using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace RiotAPISharp.Http
{
    public class Requester : IRequester
    {
        private string Key { get; set; }
        private HttpClient Client { get; set; }
        private const string httpString = "https://";
        private const string xRiotToken = "X-Riot-Token";

        public Requester(string key)
        {
            Key = key;
            Client = new HttpClient();
        }

        public async Task<string> CreateGetRequest(string url)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, httpString + url);
            request.Headers.Add(xRiotToken, Key);

            HttpResponseMessage response = await Client.SendAsync(request);
            string responseBody = await response.Content.ReadAsStringAsync();

            if (CheckIfStatusCodeIsOk(response))
            {
                return responseBody;
            }

            return null;
        }

        private bool CheckIfStatusCodeIsOk(HttpResponseMessage response)
        {
            return response.StatusCode == HttpStatusCode.OK;
        }
    }
}