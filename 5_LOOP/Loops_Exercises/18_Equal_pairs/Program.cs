using System;

namespace _18_Equal_pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var sumMin = int.MaxValue;
            var sumMax = int.MinValue;

            for (int i = 0; i < n; i++)
            {

                int sum = 0;

                for (int j = 0; j < 2; j++)
                {
                    var num = int.Parse(Console.ReadLine());

                    sum += num;
                }

                if (sumMin > sum)
                {
                    sumMin = sum;
                }

                if (sumMax < sum)
                {
                    sumMax = sum;
                }
            }

            if (sumMax == sumMin)
            {
                Console.WriteLine($"Yes, value={sumMax}");
            }

            if (sumMax > sumMin)
            {
                Console.WriteLine($"No, maxdiff={sumMax - sumMin}");
            }
        }
    }
}
