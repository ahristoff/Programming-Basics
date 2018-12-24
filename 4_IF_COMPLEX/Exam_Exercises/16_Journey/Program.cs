using System;

namespace _16_Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            if (n > 0 && n <= 100)
            {

                if (season == "summer")
                {
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {Math.Round(n * 0.3, 2)}");
                }

                else if (season == "winter")
                {
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Hotel - {Math.Round(n * 0.7, 2)}");
                }
            }

            else if (n > 100 && n <= 1000)
            {

                if (season == "summer")
                {
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Camp - {Math.Round(n * 0.4, 2)}");
                }

                else if (season == "winter")
                {
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Hotel - {Math.Round(n * 0.8, 2)}");
                }
            }

            else if (n > 1000)
            {

                if (season == "summer")
                {
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine($"Hotel - {Math.Round(n * 0.9, 2)}");
                }

                else if (season == "winter")
                {
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine($"Hotel - {Math.Round(n * 0.9, 2)}");
                }
            }
        }
    }
}
