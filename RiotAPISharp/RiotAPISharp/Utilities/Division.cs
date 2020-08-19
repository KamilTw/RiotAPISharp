namespace RiotAPISharp.Utilities
{
    public class Division
    {
        private string Value { get; set; }

        public static readonly Division I = new Division("I");
        public static readonly Division II = new Division("II");
        public static readonly Division III = new Division("III");
        public static readonly Division IV = new Division("IV");

        private Division(string value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
