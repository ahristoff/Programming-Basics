using System;

namespace _6_Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var numMin = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());

                if (numMin > num)
                {
                    numMin = num;
                }
            }

            Console.WriteLine(numMin);
        }
    }
}
