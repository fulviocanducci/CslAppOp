using System;
using System.Data;

namespace CslAppOperatorConvertion
{
    class Program
    {
        static void Main(string[] args)
        {

            Celsius c0 = new Celsius(0);
            Fahrenheit f0 = c0;
            Console.WriteLine(f0.Value);

            Fahrenheit f1 = new Fahrenheit(32);
            Celsius c1 = f1;
            Console.WriteLine(c1.Value);

            Sender s0 = new Sender(100.99d);
            int i0 = (int)s0;
            float fl0 = (float)s0;
            Console.WriteLine(s0.Value);
            Console.WriteLine(i0);
            Console.WriteLine(fl0);

            Source so0 = new Source(10);
            if (so0) // code > 0
            {
                //
            } 
            else
            {
                //
            }
            Console.WriteLine(so0);
        }
    }
}
