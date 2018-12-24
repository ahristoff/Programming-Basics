using System;

namespace _10_Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {

                for (int i = 1; i <= n / 2; i++)                 
                {

                    for (int j = 1; j <= n / 2 - i; j++)
                    {
                        Console.Write("-");
                    }

                    Console.Write("*");

                    for (int j = 1; j <= 2 * i - 2; j++)
                    {
                        Console.Write("-");
                    }

                    Console.Write("*");

                    for (int j = 1; j <= n / 2 - i; j++)
                    {
                        Console.Write("-");
                    }

                    Console.WriteLine();
                }

                for (int i = 1; i <= (n / 2) - 1; i++)       
                {

                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("-");
                    }

                    Console.Write("*");

                    for (int j = 1; j <= 2 * (n / 2 - 1) - 2 * i; j++)
                    {
                        Console.Write("-");
                    }

                    Console.Write("*");

                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("-");
                    }

                    Console.WriteLine();
                }
            }

            else                                          
            {

                for (int i = 1; i <= (n / 2) + 1; i++)
                {

                    for (int j = 1; j < ((n / 2) + 1) - i + 1; j++)
                    {
                        Console.Write("-");
                    }

                    Console.Write("*");

                    for (int j = 1; j < 2 * i - 2; j++)
                    {
                        Console.Write("-");
                    }

                    if (i == 1)
                    {
                        Console.Write("");
                    }

                    else
                    {
                        Console.Write("*");
                    }

                    for (int j = 1; j < (n / 2) + 1 - i + 1; j++)
                    {
                        Console.Write("-");
                    }

                    Console.WriteLine();
                }

                for (int i = 1; i <= (n - 1) / 2; i++)       
                {

                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("-");
                    }

                    Console.Write("*");

                    for (int j = 1; j <= 2 * ((n - 1) / 2) - 2 * i - 1; j++)
                    {
                        Console.Write("-");
                    }

                    if (i == (n - 1) / 2)
                    {
                        Console.Write("");
                    }

                    else
                    {
                        Console.Write("*");
                    }

                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("-");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
