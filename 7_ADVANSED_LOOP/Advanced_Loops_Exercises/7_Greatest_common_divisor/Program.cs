using System;

namespace _7_Greatest_common_divisor
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int c;

            while (b != 0)
            {
                c = b;
                b = a % b;
                a = c;
            }

            Console.WriteLine(a);
        }
    }
}
