namespace CslAppOperatorConvertion
{
    public class Sender
    {
        public double Value { get; }

        public Sender(double value)
        {
            Value = value;
        }

        public static explicit operator int(Sender sender)
        {
            return (int)sender.Value;
        }
        public static explicit operator float(Sender sender)
        {
            return (float)sender.Value;
        }

    }
}

        //public static Source operator +(Source s1, Source s2)
        //{
        //    return new Source(s1.Code + s2.Code);
        //}

        //public static Source operator -(Source s1, Source s2)
        //{
        //    return new Source(s1.Code + s2.Code);
        //}