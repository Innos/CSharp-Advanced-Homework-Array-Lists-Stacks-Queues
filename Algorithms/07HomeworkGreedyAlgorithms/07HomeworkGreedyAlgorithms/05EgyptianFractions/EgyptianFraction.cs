namespace _05EgyptianFractions
{
    public class EgyptianFraction
    {
        public EgyptianFraction(long value)
        {
            this.Value = value;
        }

        public long Value { get; set; }

        public override string ToString()
        {
            return string.Format("1/{0}", this.Value);
        }
    }
}
