using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_DRAW_FORT
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("/{0}\\{1}/{2}\\",
                new string('^', (int)n / 2),
                new string('_', (int)(2 * n) - 2 * (int)(n / 2) - 4),
                new string('^', (int)(n / 2)));

            for (int i = 1; i <= n - 3; i++)
            {
                Console.WriteLine("|{0}|", new string(' ', (int)(2 * n) - 2));
            }

            Console.WriteLine("|{0}{1}{2}|",
               new string(' ', (int)(n / 2) + 1),
               new string('_', (int)(2 * n) - 2 * (int)(n / 2) - 4),
               new string(' ', (int)(n / 2) + 1));

            Console.WriteLine("\\{0}/{1}\\{2}/",
                new string('_', (int)(n / 2)),
                new string(' ', (int)(2 * n) - 2 * (int)(n / 2) - 4),
                new string('_', (int)n / 2));
        }
    }
}
