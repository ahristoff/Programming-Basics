using System;

namespace _13_USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double USD = double.Parse(Console.ReadLine());
            Console.WriteLine((Math.Round(USD * 1.79549, 2)) + " BGN");
        }
    }
}
