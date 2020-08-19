namespace RiotAPISharp.Utilities
{
    public class Region
    {
        private string Value { get; set; }

        public static readonly Region AMERICAS = new Region("americas.api.riotgames.com");
        public static readonly Region ASIA = new Region("asia.api.riotgames.com");
        public static readonly Region EUROPE = new Region("europe.api.riotgames.com");
        public static readonly Region SEA = new Region("sea.api.riotgames.com");

        private Region(string value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
