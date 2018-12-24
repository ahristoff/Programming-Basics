using System;

namespace _2_Local_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string produkt = Console.ReadLine();
            string town = Console.ReadLine();
            double n = double.Parse(Console.ReadLine());

            double price = 0;

            if (town == "Sofia")
            {

                if (produkt == "coffee")
                {
                    price = 0.5 * n;
                }

                else if (produkt == "water")
                {
                    price = 0.8 * n;
                }

                else if (produkt == "beer")
                {
                    price = 1.2 * n;
                }

                else if (produkt == "sweets")
                {
                    price = 1.45 * n;
                }

                else if (produkt == "peanuts")
                {
                    price = 1.6 * n;
                }
            }

            else if (town == "Plovdiv")
            {

                if (produkt == "coffee")
                {
                    price = 0.4 * n;
                }

                else if (produkt == "water")
                {
                    price = 0.7 * n;
                }

                else if (produkt == "beer")
                {
                    price = 1.15 * n;
                }

                else if (produkt == "sweets")
                {
                    price = 1.30 * n;
                }

                else if (produkt == "peanuts")
                {
                    price = 1.5 * n;
                }
            }

            else if (town == "Varna")
            {

                if (produkt == "coffee")
                {
                    price = 0.45 * n;
                }

                else if (produkt == "water")
                {
                    price = 0.7 * n;
                }

                else if (produkt == "beer")
                {
                    price = 1.1 * n;
                }

                else if (produkt == "sweets")
                {
                    price = 1.35 * n;
                }

                else if (produkt == "peanuts")
                {
                    price = 1.55 * n;
                }
            }

            Console.WriteLine(price);
        }
    }
}
