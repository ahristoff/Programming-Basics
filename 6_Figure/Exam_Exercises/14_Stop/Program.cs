using System;

namespace _14_Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var point = n + 1;
            var underline = 2 * n + 1;

            Console.WriteLine("{0}{1}{2}",
                new string('.', point),
                new string('_', underline),
                new string('.', point));

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}//{1}\\\\{2}",
                    new string('.', point - 1),
                    new string('_', underline - 2),
                    new string('.', point - 1));
                point--;
                underline += 2;
            }

            Console.WriteLine("//{0}Stop!{1}\\\\",
                new string('_', (4 * n + 3 - 9) / 2),
                new string('_', (4 * n + 3 - 9) / 2));

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}\\\\{1}//{2}",
                    new string('.', point - 1),
                    new string('_', underline - 2),
                    new string('.', point - 1));
                point++;
                underline -= 2;
            }
        }
    }
}
