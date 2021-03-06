﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_HISTOGRAM
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 1; i <= n; i++)
            {
                var num = double.Parse(Console.ReadLine());

                if (num>=0 && num < 200)
                {
                    p1++;
                }

                else if (num >= 200 && num < 400)
                {
                    p2++;
                }

                else if (num >= 400 && num < 600)
                {
                    p3++;
                }

                else if (num >= 600 && num < 800)
                {
                    p4++;
                }

                else if (num >= 800)
                {
                    p5++;
                }
            }
           
            Console.WriteLine("{0:f2}%", ((p1 / n) * 100));
            Console.WriteLine("{0:f2}%", ((p2 / n) * 100));
            Console.WriteLine("{0:f2}%", ((p3 / n) * 100));
            Console.WriteLine("{0:f2}%", ((p4 / n) * 100));
            Console.WriteLine("{0:f2}%", ((p5 / n) * 100));
        }
    }
}
