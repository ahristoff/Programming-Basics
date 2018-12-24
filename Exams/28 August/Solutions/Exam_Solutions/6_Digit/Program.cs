using System;

namespace _6_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int N = n;
            int s;

            for (int i = 1; i <= (int)(N / 100) + (((int)(N / 10)) % 10); i++)
            {

                for (int j = 1; j <= (int)(N / 100) + N % 10; j++)
                {

                    if (n % 5 == 0)
                    {
                        s = n - (int)(N / 100);
                        Console.Write(s + " ");
                        n = s;
                    }

                    else if (n % 3 == 0)
                    {

                        s = n - (((int)(N / 10)) % 10);
                        Console.Write(s + " ");
                        n = s;
                    }

                    else
                    {

                        s = n + N % 10;
                        Console.Write(s + " ");
                        n = s;
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
