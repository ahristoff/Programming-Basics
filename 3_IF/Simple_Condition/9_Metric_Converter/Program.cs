using System;

namespace _9_Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string up = Console.ReadLine().ToLower();
            string down = Console.ReadLine().ToLower();

            var meterup = 0.0;
            var meterdown = 0.0;

            if (up == "m")
            {
                meterup = n;
            }
            else if (up == "km")
            {
                meterup = n / 0.001;
            }
            else if (up == "mm")
            {
                meterup = n / 1000;
            }
            else if (up == "cm")
            {
                meterup = n / 100;
            }
            else if (up == "mi")
            {
                meterup = n / 0.000621371192;
            }
            else if (up == "in")
            {
                meterup = n / 39.3700787;
            }
            else if (up == "ft")
            {
                meterup = n / 3.2808399;
            }
            else if (up == "yd")
            {
                meterup = n / 1.0936133;
            }

            //-----------------------------------------------------------

            if (down == "m")
            {
                meterdown = n;
            }
            else if (down == "km")
            {
                meterdown = n * 0.001;
            }
            else if (down == "mm")
            {
                meterdown = n * 1000;
            }
            else if (down == "cm")
            {
                meterdown = n * 100;
            }
            else if (down == "mi")
            {
                meterdown = n * 0.000621371192;
            }
            else if (down == "in")
            {
                meterdown = n * 39.3700787;
            }
            else if (down == "ft")
            {
                meterdown = n * 3.2808399;
            }
            else if (down == "yd")
            {
                meterdown = n * 1.0936133;
            }

            Console.WriteLine(meterdown * meterup / n);
        }
    }
}
