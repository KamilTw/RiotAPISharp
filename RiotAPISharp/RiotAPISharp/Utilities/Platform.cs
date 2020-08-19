namespace RiotAPISharp.Utilities
{
    public class Platform
    {
        private string Value { get; set; }

        public static readonly Platform BR1 = new Platform("br1.api.riotgames.com");
        public static readonly Platform EUN1 = new Platform("eun1.api.riotgames.com");
        public static readonly Platform EUW1 = new Platform("euw1.api.riotgames.com");
        public static readonly Platform JP1 = new Platform("jp1.api.riotgames.com");
        public static readonly Platform KR = new Platform("kr.api.riotgames.com");
        public static readonly Platform LA1 = new Platform("la1.api.riotgames.com");
        public static readonly Platform LA2 = new Platform("la2.api.riotgames.com");
        public static readonly Platform NA1 = new Platform("na1.api.riotgames.com");
        public static readonly Platform OC1 = new Platform("oc1.api.riotgames.com");
        public static readonly Platform TR1 = new Platform("tr1.api.riotgames.com");
        public static readonly Platform RU = new Platform("ru.api.riotgames.com");

        private Platform(string value)
        {
            Value = value;
        }
        
        public override string ToString()
        {
            return Value;
        }
    };
}
