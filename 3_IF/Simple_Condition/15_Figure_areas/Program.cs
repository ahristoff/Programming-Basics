using System;

namespace _15_Figure_areas
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input == "square")
            {
                double a = double.Parse(Console.ReadLine());

                Console.WriteLine(Math.Round(a * a, 3));
            }

            else if (input == "rectangle")
            {
                double x = double.Parse(Console.ReadLine());
                double z = double.Parse(Console.ReadLine());

                Console.WriteLine(Math.Round(x * z, 3));
            }

            else if (input == "circle")
            {
                double r = double.Parse(Console.ReadLine());

                Console.WriteLine(Math.Round(Math.PI * r * r, 3));
            }

            else  if (input == "triangle")
            {
                double h = double.Parse(Console.ReadLine());
                double l = double.Parse(Console.ReadLine());

                Console.WriteLine(Math.Round(h * l / 2, 3));
            }
        }
    }
}
