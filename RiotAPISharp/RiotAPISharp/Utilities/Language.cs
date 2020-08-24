namespace RiotAPISharp.Utilities
{
    public class Language
    {
        private string Value { get; set; }

        public static readonly Language Czech = new Language("cs_CZ");
        public static readonly Language Greek = new Language("el_GR");
        public static readonly Language Polish = new Language("pl_PL");
        public static readonly Language Romanian = new Language("ro_RO");
        public static readonly Language Hungarian = new Language("hu_HU");
        public static readonly Language EnglishGB= new Language("en_GB");
        public static readonly Language German = new Language("de_DE");
        public static readonly Language SpanishES = new Language("es_ES");
        public static readonly Language Italian = new Language("it_IT");
        public static readonly Language French = new Language("fr_FR");
        public static readonly Language Japanese = new Language("ja_JP");
        public static readonly Language Korean = new Language("ko_KR");
        public static readonly Language SpanishMX = new Language("es_MX");
        public static readonly Language SpanishAR = new Language("es_AR");
        public static readonly Language Portuguese = new Language("pt_BR");
        public static readonly Language EnglishUS = new Language("en_US");
        public static readonly Language EnglishAU = new Language("en_AU");
        public static readonly Language Russian = new Language("ru_RU");
        public static readonly Language Turkish = new Language("tr_TR");
        public static readonly Language Malay = new Language("ms_MY");
        public static readonly Language EnglishPH = new Language("en_PH");
        public static readonly Language EnglishSG = new Language("en_SG");
        public static readonly Language Thai = new Language("th_TH");
        public static readonly Language Vietnamese = new Language("vn_VN");
        public static readonly Language Indonesian = new Language("id_ID");
        public static readonly Language ChineseMY = new Language("zh_MY");
        public static readonly Language ChineseCN = new Language("zh_CN");
        public static readonly Language ChineseTW = new Language("zh_TW");

        private Language(string value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
