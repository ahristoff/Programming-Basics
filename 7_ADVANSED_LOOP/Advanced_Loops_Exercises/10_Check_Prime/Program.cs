using System;

namespace _10_Check_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 2)
            {
                Console.WriteLine("Not Prime");
            }
            else
            {
                int a = 1;

                for (int i = 2; i <= n - 1; i++)
                {
                    if (n % i == 0)
                    {

                        Console.WriteLine("Not Prime");

                        a = 2;

                        break;
                    }
                }

                if (a == 1)
                {
                    Console.WriteLine("Prime");
                }
            }       
        }
    }
}
