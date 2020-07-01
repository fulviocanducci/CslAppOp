namespace CslAppOperatorConvertion
{
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
}

        //public static Source operator +(Source s1, Source s2)
        //{
        //    return new Source(s1.Code + s2.Code);
        //}

        //public static Source operator -(Source s1, Source s2)
        //{
        //    return new Source(s1.Code + s2.Code);
        //}