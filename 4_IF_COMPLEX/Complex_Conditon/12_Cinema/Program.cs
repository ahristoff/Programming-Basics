using System;

namespace _12_Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string kind = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            var price = -1.0;

            if (kind == "Premiere")
            {
                price = row * col * 12.0;
            }

            else if (kind == "Normal")
            {
                price = row * col * 7.5;
            }

            else if (kind == "Discount")
            {
                price = row * col * 5.0;
            }

            Console.WriteLine($"{price:f2} leva");            
        }
    }
}
