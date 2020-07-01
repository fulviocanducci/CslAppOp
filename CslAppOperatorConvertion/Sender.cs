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