using RiotAPISharp.Endpoints.Interfaces;
using RiotAPISharp.Model.ClashV1;
using RiotAPISharp.Utilities;
using System.Collections.Generic;

namespace RiotAPISharp.Endpoints.Implementations
{
    public class ClashV1 : EndpointBase, IClashV1
    {
        private const string playersBySummonerIdUrl = "{0}/lol/clash/v1/players/by-summoner/{1}";
        private const string teamsByTeamIdUrl = "{0}/lol/clash/v1/teams/{1}";
        private const string tournamentsUrl = "{0}/lol/clash/v1/tournaments";
        private const string tournamentsByTeamIdUrl = "{0}/lol/clash/v1/tournaments/by-team/{1}";
        private const string tournamentsByTournamentIdUrl = "{0}/lol/clash/v1/tournaments/{1}";

        public ClashV1(string key) : base(key)
        {

        }

        public IEnumerable<PlayerDTO> GetPlayersBySummonerId(Platform platform, string summonerId)
        {
            string url = string.Format(playersBySummonerIdUrl, platform.ToString(), summonerId);

            return GetObjectOfType<IEnumerable<PlayerDTO>>(url);
        }

        public TeamDTO GetTeamsByTeamId(Platform platform, string teamId)
        {
            string url = string.Format(teamsByTeamIdUrl, platform.ToString(), teamId);

            return GetObjectOfType<TeamDTO>(url);
        }

        public IEnumerable<TournamentDTO> GetTournaments(Platform platform)
        {
            string url = string.Format(tournamentsUrl, platform.ToString());

            return GetObjectOfType<IEnumerable<TournamentDTO>>(url);
        }

        public TournamentDTO GetTournamentsByTeamId(Platform platform, string teamId)
        {
            string url = string.Format(tournamentsByTeamIdUrl, platform.ToString(), teamId);

            return GetObjectOfType<TournamentDTO>(url);
        }

        public TournamentDTO GetTournamentsByTournamentId(Platform platform, int tournamentId)
        {
            string url = string.Format(tournamentsByTournamentIdUrl, platform.ToString(), tournamentId);

            return GetObjectOfType<TournamentDTO>(url);
        }
    }
}