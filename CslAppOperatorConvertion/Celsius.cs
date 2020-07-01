namespace CslAppOperatorConvertion
{
    public class Celsius
    {
        public decimal Value { get; }

        public Celsius(decimal value)
        {
            Value = value;
        }

        public static implicit operator Fahrenheit(Celsius celsius)
        {
            //°F = °C × 1.8 + 32;
            decimal value = celsius.Value * 1.8m + 32;
            return new Fahrenheit(value);
        }
    }

    public class Fahrenheit
    {
        public decimal Value { get; }

        public Fahrenheit(decimal value)
        {
            Value = value;
        }

        public static implicit operator Celsius(Fahrenheit fahrenheit)
        {
            //°C = (°F − 32) ÷ 1.8
            decimal value = (fahrenheit.Value - 32) / 1.8m;
            return new Celsius(value);
        }
    }

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

    public class Source
    {
        public int Code { get; }
        public Source(int code)
        {
            Code = code;
        }

        public static implicit operator bool(Source source)
        {
            return source.Code > 0;
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