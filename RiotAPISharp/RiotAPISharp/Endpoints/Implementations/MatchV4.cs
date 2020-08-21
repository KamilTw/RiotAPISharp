using RiotAPISharp.Endpoints.Interfaces;
using RiotAPISharp.Model.MatchV4;
using RiotAPISharp.Utilities;
using System;
using System.Collections.Generic;

namespace RiotAPISharp.Endpoints.Implementations
{
    public class MatchV4 : EndpointBase, IMatchV4
    {
        private const string matchlistsByAccountUrl = "{0}/lol/match/v4/matchlists/by-account/{1}?";
        private const string matchesByMatchIdUrl = "{0}/lol/match/v4/matches/{1}";
        private const string timelinesByMatchIdUrl = "{0}/lol/match/v4/timelines/by-match/{1}";
        private const string matchesByTournamentCodeUrl = "{0}/lol/match/v4/matches/by-tournament-code/{1}/ids";
        private const string matchesByMatchIdAndByTournamentCodeUrl = "{0}/lol/match/v4/matches/{1}/by-tournament-code/{2}";

        private const string championUrl = "champion={0}&";
        private const string queueUrl = "queue={0}&";
        private const string endTimeUrl = "endTime={0}&";
        private const string beginTimeUrl = "beginTime={0}&";
        private const string endIndexUrl = "endIndex={0}&";
        private const string beginIndexUrl = "beginIndex={0}&";

        public MatchV4(string key) : base(key)
        {

        }

        public MatchlistDTO GetMatchlistsByAccount(Platform platform, string accountId,
            IEnumerable<Champion> champions = null, IEnumerable<GameMode> gamemode = null, DateTime? endTime = null, DateTime? beginTime = null, int? endIndex = null, int? beginIndex = null)
        {
            string urlForAdditionalParameters = "";
            AddUrlForAdditionalParameter(championUrl, champions, ref urlForAdditionalParameters);
            AddUrlForAdditionalParameter(queueUrl, gamemode, ref urlForAdditionalParameters);
            AddUrlForAdditionalParameter(endTimeUrl, ConvertDatatimeToUnixTime(endTime), ref urlForAdditionalParameters);
            AddUrlForAdditionalParameter(beginTimeUrl, ConvertDatatimeToUnixTime(beginTime), ref urlForAdditionalParameters);
            AddUrlForAdditionalParameter(endIndexUrl, endIndex, ref urlForAdditionalParameters);
            AddUrlForAdditionalParameter(beginIndexUrl, beginIndex, ref urlForAdditionalParameters);

            string url = string.Format(matchlistsByAccountUrl, platform.ToString(), accountId) + urlForAdditionalParameters;

            return GetObjectOfType<MatchlistDTO>(url);
        }

        public MatchDTO GetMatchesByMatchId(Platform platform, long matchId)
        {
            string url = string.Format(matchesByMatchIdUrl, platform.ToString(), matchId);

            return GetObjectOfType<MatchDTO>(url);
        }

        public MatchTimelineDTO GetTimelinesByMatchId(Platform platform, long matchId)
        {
            string url = string.Format(timelinesByMatchIdUrl, platform.ToString(), matchId);

            return GetObjectOfType<MatchTimelineDTO>(url);
        }

        public IEnumerable<long> GetMatchesByTournamentCode(Platform platform, string tournamentCode)
        {
            string url = string.Format(matchesByTournamentCodeUrl, platform.ToString(), tournamentCode);

            return GetObjectOfType<IEnumerable<long>>(url);
        }

        public MatchDTO GetMatchesByMatchIdAndByTournamentCode(Platform platform, long matchId, string tournamentCode)
        {
            string url = string.Format(matchesByMatchIdAndByTournamentCodeUrl, platform.ToString(), matchId, tournamentCode);

            return GetObjectOfType<MatchDTO>(url);
        }

        private long? ConvertDatatimeToUnixTime(DateTime? datetime)
        {
            if (datetime != null)
            {
                return ((DateTimeOffset)datetime).ToUnixTimeMilliseconds();
            }

            return null;
        }

        private void AddUrlForAdditionalParameter<T>(string url, IEnumerable<T> parameters, ref string urlForAdditionalParameters)
        {
            if (parameters != null)
            {
                foreach (T parameter in parameters)
                {
                    urlForAdditionalParameters += string.Format(url, (int)(object)parameter);
                }
            }
        }

        private void AddUrlForAdditionalParameter<T>(string url, T parameter, ref string urlForAdditionalParameters)
        {
            if (parameter != null)
            {
                urlForAdditionalParameters += string.Format(url, parameter);
            }
        }
    }
}
