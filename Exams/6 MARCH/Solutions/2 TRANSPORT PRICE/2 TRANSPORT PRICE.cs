using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_TRANSPORT_PRICE
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();

            double distance = 0;

            if (n < 20)
            {

                if (dayOrNight == "day")
                {
                    distance = 0.7 + 0.79 * n;
                }

                if (dayOrNight == "night")
                {
                    distance = 0.7 + 0.9 * n;
                }
            }

            else if (n >= 20 && n < 100)
            {
                distance = 0.09 * n;
            }

            else if (n >= 100)
            {
                distance = 0.06 * n;
            }

            Console.WriteLine(distance);
        }
        
        
    }
}
