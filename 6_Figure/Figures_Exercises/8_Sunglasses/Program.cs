using System;

namespace _8_Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', 2 * n));

            for (int i = 1; i <= n - 2; i++)
            {

                if (i == (n - 1) / 2)
                {

                    Console.Write("*");
                    Console.Write(new string('/', n + n - 2));
                    Console.Write("*");
                    Console.Write(new string('|', n));
                    Console.Write("*");
                    Console.Write(new string('/', n + n - 2));
                    Console.WriteLine("*");
                }

                else if (true)
                {

                    Console.Write("*");
                    Console.Write(new string('/', n + n - 2));
                    Console.Write("*");
                    Console.Write(new string(' ', n));
                    Console.Write("*");
                    Console.Write(new string('/', n + n - 2));
                    Console.WriteLine("*");
                }
            }

            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', 2 * n));
        }
    }
}
