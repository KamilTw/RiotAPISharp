namespace RiotAPISharp.Utilities
{
    public class Queue
    {
        private string Value { get; set; }

        public static readonly Queue RankedSolo5x5 = new Queue("RANKED_SOLO_5x5");
        public static readonly Queue RankedFlex5x5 = new Queue("RANKED_FLEX_SR");

        private Queue(string value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
