using System;

namespace _14_Table_with_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int a = 1;

            for (int i = 1; i <= n; i++)
            {

                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write("{0} ", a);

                    a++;
                }

                Console.Write(n);

                for (int j = 1; j < i; j++)
                {
                    Console.Write(" {0}", a - 1);

                    a--;
                }

                Console.WriteLine();

                a = i + 1;
            }
        }
    }
}
