using System;

namespace _4_Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var sum = 0;

            for (var i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                sum += num;
            }

            Console.WriteLine("Sum = " + sum);
        }
    }
}
