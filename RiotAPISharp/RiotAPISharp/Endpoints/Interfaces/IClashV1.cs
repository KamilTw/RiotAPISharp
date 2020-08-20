using RiotAPISharp.Model.ClashV1;
using RiotAPISharp.Utilities;
using System.Collections.Generic;

namespace RiotAPISharp.Endpoints.Interfaces
{
    public interface IClashV1
    {
        public IEnumerable<PlayerDTO> GetPlayersBySummonerId(Platform platform, string summonerId);

        public TeamDTO GetTeamsByTeamId(Platform platform, string teamId);

        public IEnumerable<TournamentDTO> GetTournaments(Platform platform);

        public TournamentDTO GetTournamentsByTeamId(Platform platform, string teamId);

        public TournamentDTO GetTournamentsByTournamentId(Platform platform, int tournamentId);
    }
}