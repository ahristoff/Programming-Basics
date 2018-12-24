using System;

namespace _5_Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var numMax = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());

                if (numMax < num)
                {
                    numMax = num;
                }
            }

            Console.WriteLine(numMax);
        }
    }
}
