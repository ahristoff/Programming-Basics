using System;

namespace _8_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int fact = 1;

            while (n > 0)
            {
                fact *= n;
                n--;
            }

            //for (int i = 1; i <= n; i++)
            //{
            //    fact *= i;
            //}

            Console.WriteLine(fact);
        }
    }
}
