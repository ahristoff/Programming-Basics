using System;

namespace _3_Excellent_or_not
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            if (n >= 5.5)
            {
                Console.WriteLine("Excellent!");
            }

            else
            {
                Console.WriteLine("Not excellent.");
            }
        }
    }
}
