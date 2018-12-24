using System;

namespace _21_Tom_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            int NormDiff = 30000 - ((365 - days) * 63 + (days * 127));
            int hours = (int)NormDiff / 60;
            int minutes = (int)NormDiff % 60;

            if (NormDiff >= 0)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
            else if (NormDiff < 0)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{Math.Abs(hours)} hours and {Math.Abs(minutes)} minutes more for play");
            }
        }
    }
}
