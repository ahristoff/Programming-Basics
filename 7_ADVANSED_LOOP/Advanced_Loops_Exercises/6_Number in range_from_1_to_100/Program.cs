using System;

namespace _6_Number_in_range_from_1_to_100
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a number in the range[1...100]: ");

            int n = int.Parse(Console.ReadLine());

            while (n <= 0 || n > 100)
            {

                Console.WriteLine("Invalid number!");
                Console.Write("Enter a number in the range[1...100]: ");

                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The number is: {n}");
        }
    }
}
