using System;

namespace _7_Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var sum1 = 0;
            var sum2 = 0;
            var sum = 0;
            
            for (int i = 1; i <= 2 * n; i++)
            {

                var num = int.Parse(Console.ReadLine());

                if (i > 0 && i <= n)
                {
                    sum1 += num;
                }

                else if (i > n && i <= 2 * n)
                {
                    sum2 += num;
                }
            }

            if (sum1 == sum2)
            {
                Console.WriteLine("Yes, sum = " + sum1);
            }

            else if (sum1 != sum2)
            {
                sum = Math.Abs(sum1 - sum2);
                Console.WriteLine("No, diff = " + sum);

            }
        }
    }
}
