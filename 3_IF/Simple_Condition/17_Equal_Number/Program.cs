using System;

namespace _17_Equal_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a != b || b != c || a != c)
            {
                Console.WriteLine("no");
            }

            else
            {
                Console.WriteLine("yes");
            }
        }
    }
}
