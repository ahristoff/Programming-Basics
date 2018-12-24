using System;

namespace _11_Only_even_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter even number: ");

            int n;

            while (true)
            {

                try
                {

                    n = int.Parse(Console.ReadLine());

                    if (n % 2 == 0)
                    {

                        if (n == 0)
                        {

                            Console.WriteLine("The number is not even.");
                            Console.Write("Enter even number: ");
                            continue;
                        }

                        Console.WriteLine("Even number entered: {0}", n);

                        break;
                    }

                    else if (n % 1 == 0)
                    {

                        Console.WriteLine("The number is not even.");
                        Console.Write("Enter even number: ");
                    }
                }

                catch
                {

                    Console.WriteLine("Invalid number");
                    Console.Write("Enter even number: ");
                }
            }
        }
    }
}
