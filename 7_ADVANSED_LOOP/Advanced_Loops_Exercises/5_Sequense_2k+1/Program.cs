using System;

namespace _5_Sequense_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var num = 1;

            //for (int i = 1; i <= n; i++)
            //{
            //    if (num <= n)
            //    {
            //        Console.WriteLine(num);
            //        num = 2 * num + 1;
            //    } 
            //}

            while (num <= n)
            {
                Console.WriteLine(num);
                num = 2 * num + 1;
            }
        }
    }
}
