using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            double countOld = double.Parse(Console.ReadLine());
            double countStudys = double.Parse(Console.ReadLine());
            double countDays = double.Parse(Console.ReadLine());
            string transport = Console.ReadLine();

            double transOld = 0;
            double transStudys = 0;
            double allTrans = 0;
            double hotel = 0;
            double com = 0;

            double price = 0;
            if (transport == "airplane")
            {

                transOld = countOld * 70;
                transStudys = countStudys * 50;
                allTrans = 2 * (transOld + transStudys);

                hotel = countDays * 82.99;

                com = (allTrans + hotel) * 0.1;

                price = allTrans + hotel + com;
            }

            else if (transport == "train")
            {

                if (countStudys + countOld < 50)
                {

                    transOld = countOld * 24.99;
                    transStudys = countStudys * 14.99;
                    allTrans = 2 * (transOld + transStudys);

                    hotel = countDays * 82.99;

                    com = (allTrans + hotel) * 0.1;

                    price = allTrans + hotel + com;
                }

                else if (countStudys + countOld >= 50)
                {

                    transOld = countOld * (12.495);
                    transStudys = countStudys * (7.495);
                    allTrans = 2.0 * (transOld + transStudys);

                    hotel = countDays * 82.99;

                    com = (allTrans + hotel) * 0.1;

                    price = (allTrans + hotel + com);
                }
            }

            else if (transport == "bus")
            {

                transOld = countOld * 32.50;
                transStudys = countStudys * 28.50;
                allTrans = 2 * (transOld + transStudys);

                hotel = countDays * 82.99;

                com = (allTrans + hotel) * 0.1;

                price = allTrans + hotel + com;
            }

            else if (transport == "boat")
            {

                transOld = countOld * 42.99;
                transStudys = countStudys * 39.99;
                allTrans = 2 * (transOld + transStudys);

                hotel = countDays * 82.99;

                com = (allTrans + hotel) * 0.1;

                price = allTrans + hotel + com;
            }

            Console.WriteLine("{0:f2}", price);
        }
    }
}
