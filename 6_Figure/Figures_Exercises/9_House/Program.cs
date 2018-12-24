using System;

namespace _9_House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                for (int i = 1; i <= n / 2; i++)           //above
                {

                    for (int j = 1; j <= n / 2 - i; j++)
                    {
                        Console.Write("-");
                    }

                    for (int j = 1; j <= 2 * i; j++)
                    {
                        Console.Write("*");
                    }

                    for (int j = 1; j <= n / 2 - i; j++)
                    {
                        Console.Write("-");
                    }

                    Console.WriteLine();
                }

                for (int i = 1; i <= n / 2; i++)     //below
                {

                    Console.Write("|");                  
                    Console.Write(new string('*', n - 2));
                    Console.WriteLine("|");
                }
            }

            else
            {
                for (int i = 1; i <= (n + 1) / 2; i++)          //above
                {

                    for (int j = 1; j <= (n + 1) / 2 - i; j++)
                    {
                        Console.Write("-");
                    }

                    for (int j = 1; j <= 2 * i - 1; j++)
                    {
                        Console.Write("*");
                    }

                    for (int j = 1; j <= n / 2 - i + 1; j++)
                    {
                        Console.Write("-");
                    }

                    Console.WriteLine();
                }

                for (int i = 1; i <= (n - 1) / 2; i++)     //below
                {
                    Console.Write("|");

                    for (int j = 1; j <= n - 2; j++)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine("|");
                }
            }
        }
    }
}
