using System;

namespace _12_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int n1 = 1;
            int n2 = 1;
            int sum = 0;

            for (int i = 1; i <= n - 1; i++)
            {

                sum = n1 + n2;
                n1 = n2;
                n2 = sum;
            }

            Console.WriteLine(n2);
        }
    }
}
