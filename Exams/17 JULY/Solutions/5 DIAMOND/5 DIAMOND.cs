using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_DIAMOND
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var point = n;
            var stars = 3 * n - 2;

            for (int i = 1; i <= n + 1; i++)
            {

                if (i == 1)
                {

                    Console.WriteLine("{0}*{1}*{2}",
                     new string('.', point),
                     new string('*', stars),
                     new string('.', point));
                }

                else if (i == n + 1)
                {
                    Console.WriteLine("{0}",

                    new string('*', 5 * n));
                }

                else if (i > 1 && i < n + 1)
                {

                    Console.WriteLine("{0}*{1}*{2}",
                    new string('.', point),
                    new string('.', stars),
                    new string('.', point));
                }

                point--;
                stars += 2;
            }

            for (int i = 1; i <= 2 * n; i++)
            {

                Console.WriteLine("{0}*{1}*{2}",
                    new string('.', point + 2),
                    new string('.', stars - 4),
                    new string('.', point + 2));

                point++;
                stars -= 2;
            }

            Console.WriteLine("{0}*{1}*{2}",
                   new string('.', point + 2),
                   new string('*', stars - 4),
                   new string('.', point + 2));
        }
    }
}
