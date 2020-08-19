namespace RiotAPISharp.Utilities
{
    public class Tier
    {
        private string Value { get; set; }

        public static readonly Tier Challenger = new Tier("CHALLENGER");
        public static readonly Tier Grandmaster = new Tier("GRANDMASTER");
        public static readonly Tier Master = new Tier("MASTER");
        public static readonly Tier Diamond = new Tier("DIAMOND");
        public static readonly Tier Platinum = new Tier("PLATINUM");
        public static readonly Tier Gold = new Tier("GOLD");
        public static readonly Tier Silver = new Tier("SILVER");
        public static readonly Tier Bronze = new Tier("BRONZE");
        public static readonly Tier Iron = new Tier("IRON");

        private Tier(string value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
