namespace RiotAPISharp.Model.ClashV1
{
    public class TournamentPhaseDTO
    {
        public int Id { get; set; }

        public long RegistrationTime { get; set; }

        public long StartTime { get; set; }

        public bool Cancelled { get; set; }
    }
}