using RiotAPISharp.Model.MatchV4;
using RiotAPISharp.Utilities;
using System;
using System.Collections.Generic;

namespace RiotAPISharp.Endpoints.Interfaces
{
    public interface IMatchV4
    {
        public MatchDTO GetMatchesByMatchId(Platform platform, long matchId);

        public MatchDTO GetMatchesByMatchIdAndByTournamentCode(Platform platform, long matchId, string tournamentCode);

        public IEnumerable<long> GetMatchesByTournamentCode(Platform platform, string tournamentCode);

        public MatchlistDTO GetMatchlistsByAccount(Platform platform, string accountId, IEnumerable<Champion> champions = null, IEnumerable<GameMode> gamemode = null,
                                                    DateTime? endTime = null, DateTime? beginTime = null, int? endIndex = null, int? beginIndex = null);
        
        public MatchTimelineDTO GetTimelinesByMatchId(Platform platform, long matchId);
    }
}