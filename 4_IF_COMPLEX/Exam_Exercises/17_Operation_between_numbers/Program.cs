using System;

namespace _17_Operation_between_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            string sight = Console.ReadLine();

            double x = 0;

            if (sight == "+")
            {
                x = (x1 + x2) % 2;

                if (x == 0)
                {
                    Console.WriteLine($"{x1} {sight} {x2} = {x1 + x2} - even");
                }

                else
                {
                    Console.WriteLine($"{x1} {sight} {x2} = {x1 + x2} - odd");
                }
            }

            else if (sight == "*")
            {
                x = (x1 * x2) % 2;

                if (x == 0)
                {
                    Console.WriteLine($"{x1} {sight} {x2} = {x1 * x2} - even");
                }

                else
                {
                    Console.WriteLine($"{x1} {sight} {x2} = {x1 * x2} - odd");
                }
            }

            else if (sight == "/")
            {

                if (x2 != 0)
                {
                    x = ((x1 / x2) % 2);

                    if (x == 0)
                    {
                        Console.WriteLine($"{x1} {sight} {x2} = {x1 / x2} - even");
                    }

                    else if (x == 1)
                    {
                        Console.WriteLine($"{x1} {sight} {x2} = {x1 / x2} - odd");
                    }

                    else
                    {
                        Console.WriteLine($"{x1} {sight} {x2} = {x1 / x2}");
                    }
                }

                if (x2 == 0)
                {
                    Console.WriteLine($"Cannot divide {x1} by zero");
                }
            }

            else if (sight == "-")
            {

                x = ((x1 - x2) % 2);

                if (x == 0)
                {
                    Console.WriteLine($"{x1} {sight} {x2} = {x1 - x2} - even");
                }

                else
                {
                    Console.WriteLine($"{x1} {sight} {x2} = {x1 - x2} - odd");
                }
            }

            else if (sight == "%")
            {

                x = ((x1 % x2) % 2);

                if (x == 0)
                {
                    Console.WriteLine($"{x1} {sight} {x2} = {x1 % x2}");
                }

                else
                {
                    Console.WriteLine($"{x1} {sight} {x2} = {x1 % x2}");
                }
            }
        }
    }
}
