using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            double allsum = 0;
            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;
            double sum4 = 0;
            double sum5 = 0;

            for (int i = 1; i <= n; i++)
            {

                var num = int.Parse(Console.ReadLine());

                allsum += num;

                if (num <= 5)
                {
                    sum1 += num;
                }

                else if (num > 5 && num <= 12)
                {
                    sum2 += num;
                }

                else if (num > 12 && num <= 25)
                {
                    sum3 += num;
                }

                else if (num > 25 && num <= 40)
                {
                    sum4 += num;
                }

                else if (num >= 41)
                {
                    sum5 += num;
                }
            }

            Console.WriteLine("{0:f2}%", (sum1 / allsum) * 100);
            Console.WriteLine("{0:f2}%", (sum2 / allsum) * 100);
            Console.WriteLine("{0:f2}%", (sum3 / allsum) * 100);
            Console.WriteLine("{0:f2}%", (sum4 / allsum) * 100);
            Console.WriteLine("{0:f2}%", (sum5 / allsum) * 100);
        }
    }
}
