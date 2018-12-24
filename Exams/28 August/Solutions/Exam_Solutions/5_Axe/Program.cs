using System;

namespace _5_Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var leftD = 3 * n;
            var midD = 0;
            var rightD = 5 * n - 2 - leftD;
            var stars = 3 * n;

            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine("{0}*{1}*{2}",
                    new string('-', leftD),
                    new string('-', midD),
                    new string('-', rightD));

                midD++;
                rightD--;
            }

            for (int i = 1; i <= n / 2; i++)
            {

                Console.WriteLine("{0}*{1}*{2}",
                    new string('*', leftD),
                    new string('-', midD - 1),
                    new string('-', rightD + 1));
            }

            for (int i = 1; i <= (n / 2) - 1; i++)
            {

                Console.WriteLine("{0}*{1}*{2}",
                    new string('-', leftD),
                    new string('-', midD - 1),
                    new string('-', rightD + 1));

                leftD--;
                midD += 2;
                rightD--;
            }

            Console.WriteLine("{0}*{1}*{2}",
                new string('-', leftD),
                new string('*', midD - 1),
                new string('-', rightD + 1));
        }
    }
}
