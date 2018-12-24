using System;

namespace _16_Element_Equal_to_sum_the_others_elements
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            var sum = 0;
            var max = int.MinValue;

            for (int i = 0; i < n; i++)
            {

                var num = int.Parse(Console.ReadLine());

                sum = sum + num;

                if (max < num)
                {
                    max = num;
                }
            }

            if (max == sum - max)
            {
                Console.WriteLine("Yes Sum = " + max);
            }

            else
            {
                Console.WriteLine("No Diff = " + Math.Abs(max - (sum - max)));
            }
        }
    }
}
