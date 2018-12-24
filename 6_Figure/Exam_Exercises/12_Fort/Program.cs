using System;

namespace _12_Fort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var symbol = (int)n / 2;
            var underDashes = 2 * n - 2 * symbol - 4;

            Console.WriteLine("/{0}\\{1}/{2}\\",
                new string('^', symbol),
                new string('_', underDashes),
                new string('^', symbol));

            for (int i = 1; i <= n - 3; i++)
            {
                Console.WriteLine("|{0}|", new string(' ', 2 * n - 2));
            }

            Console.WriteLine("|{0}{1}{2}|",
                new string(' ', symbol + 1),
                new string('_', underDashes),
                new string(' ', symbol + 1));

            Console.WriteLine("\\{0}/{1}\\{2}/",
                new string('_', symbol),
                new string(' ', underDashes),
                new string('_', symbol));
        }
    }
}
