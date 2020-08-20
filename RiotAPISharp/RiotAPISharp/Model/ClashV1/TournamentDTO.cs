using System.Collections.Generic;

namespace RiotAPISharp.Model.ClashV1
{
    public class TournamentDTO
    {
        public int Id { get; set; }

        public int ThemeId { get; set; }

        public string NameKey { get; set; }

        public string NameKeySecondary { get; set; }

        public IEnumerable<TournamentPhaseDTO> Schedule { get; set; }
    }
}
