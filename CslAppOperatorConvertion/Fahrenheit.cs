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