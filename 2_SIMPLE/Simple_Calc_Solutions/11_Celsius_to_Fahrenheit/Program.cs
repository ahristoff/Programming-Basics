using System;

namespace _11_Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round((celsius * 1.8) + 32,2));
        }
    }
}
