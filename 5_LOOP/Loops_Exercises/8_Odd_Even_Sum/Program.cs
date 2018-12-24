using System;

namespace _8_Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); 

            var sum = 0;
            var sum1 = 0;
            var sum2 = 0;

            for (int i = 1; i <= n; i++)
            {

                var num = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    sum1 = sum1 + num;
                }

                else if (i % 2 == 1)
                {
                    sum2 = sum2 + num;
                }
            }

            if (sum1 == sum2)
            {
                Console.WriteLine("Yes Sum = " + sum1);
            }

            else if (sum1 != sum2)
            {
                sum = Math.Abs(sum1 - sum2);

                Console.WriteLine("No Diff = " + sum);
            }
        }
    }
}
