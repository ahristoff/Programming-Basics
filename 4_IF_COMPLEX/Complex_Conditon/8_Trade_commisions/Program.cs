using System;

namespace _8_Trade_commisions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double s = double.Parse(Console.ReadLine());

            var com = -1.0;

            if (town == "Sofia")
            {

                if (s >= 0 && s <= 500)
                {
                    com = s * 0.05;
                }

                else if (s > 500 && s <= 1000)
                {
                    com = s * 0.07;
                }

                else if (s > 1000 && s <= 10000)
                {
                    com = s * 0.08;
                }

                else if (s > 10000)
                {
                    com = s * 0.12;
                }
            }

            else if (town == "Varna")
            {

                if (s >= 0 && s <= 500)
                {
                    com = s * 0.045;
                }

                else if (s > 500 && s <= 1000)
                {
                    com = s * 0.075;
                }

                else if (s > 1000 && s <= 10000)
                {
                    com = s * 0.1;
                }

                else if (s > 10000)
                {
                    com = s * 0.13;
                }
            }
            else if (town == "Plovdiv")
            {

                if (s >= 0 && s <= 500)
                {
                    com = s * 0.055;
                }

                else if (s > 500 && s <= 1000)
                {
                    com = s * 0.08;
                }

                else if (s > 1000 && s <= 10000)
                {
                    com = s * 0.12;
                }

                else if (s > 10000)
                {
                    com = s * 0.145;
                }
            }
            if (com >= 0)
            {
                Console.WriteLine("{0:f2}", com);
            }

            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
