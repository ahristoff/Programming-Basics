using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_BACK_TO_THE_PAST
{
    class Program
    {
        static void Main(string[] args)
        {
            double heritageMoney = double.Parse(Console.ReadLine());
            double year = double.Parse(Console.ReadLine());

            for (int i = 1800; i <= year; i++)
            {
                if (i%2 ==0)
                {
                    heritageMoney -= 12000;
                }

                else
                {
                    heritageMoney-= 12000 +50*((i-1800)+18);
                }
            }

            if (heritageMoney >= 0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", heritageMoney);
            }

            else if (heritageMoney < 0)
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.",Math.Abs(heritageMoney));
            }
        }
    }
}
