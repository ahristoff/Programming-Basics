using System;

namespace _13_Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string kindOfYear = Console.ReadLine();
            var p = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            double games = ((((48 - h) * 3 / 4) + (p * 2 / 3)) + h);

            if (kindOfYear == "leap")
            {
                Console.WriteLine(Math.Truncate(games * 1.15));
            }

            else if (kindOfYear == "normal")
            {
                Console.WriteLine(Math.Truncate(games));
            }
        }
    }
}
