using System;

namespace _14_Point_in_the_Figur
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = double.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());

            if (((x > 0 && x < 3 * h) && (y > 0 && y < h)) || ((x > h && x < 2 * h) && (y > h && y < 4 * h)))
            {
                Console.WriteLine("inside");
            }

            else if (((x == 0) && (y >= 0 && y <= h)) || ((x == 3 * h) && (y >= 0 && y <= h)) || ((y == 0) && (x >= 0 && x <= 3 * h)) || ((y == h) && (x >= 0 && x <= 3 * h)) || ((x == h) && (y >= h && y <= 4 * h)) || ((x == 2 * h) && (y >= h && y <= 4 * h)) || ((y == h) && (x >= h && x <= 2 * h)) || ((y == 4 * h) && (x >= h && x <= 2 * h)))
            {
                Console.WriteLine("border");
            }

            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}
