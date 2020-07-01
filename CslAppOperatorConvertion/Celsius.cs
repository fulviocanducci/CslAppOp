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
}