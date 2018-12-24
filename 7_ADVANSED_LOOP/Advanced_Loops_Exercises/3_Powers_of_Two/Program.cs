using System;

namespace _3_Powers_of_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var num = 1;

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(num);

                num *= 2;
            }
        }
    }
}
