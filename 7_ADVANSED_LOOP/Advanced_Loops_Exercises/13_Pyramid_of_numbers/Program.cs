using System;

namespace _13_Pyramid_of_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int a = 1;

            for (int i = 1; i <= n; i++)
            {

                for (int j = 1; j <= i; j++)
                {

                    if (a <= n)
                    {

                        Console.Write("{0} ", a);

                        a++;
                    }

                    else
                    {
                        break;
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
