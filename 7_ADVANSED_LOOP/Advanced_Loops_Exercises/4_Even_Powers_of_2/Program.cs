using System;

namespace _4_Even_Powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var num = 1;

            for (int i = 0; i <= (int)n / 2; i++)
            {
                Console.WriteLine(num);

                num *= 4;
            }
        }
    }
}
