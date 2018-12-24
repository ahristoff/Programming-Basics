using System;

namespace _1_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            double day = double.Parse(Console.ReadLine());
            double moneyProDay = double.Parse(Console.ReadLine());
            double currancyRate = double.Parse(Console.ReadLine());

            double moneyProMonth = moneyProDay * day;
            double year = 12 * moneyProMonth + 2.5 * moneyProMonth;

            double d = year - year * 25 / 100;

            double profit = d / 365;

            Console.WriteLine("{0:f2}", profit * currancyRate);
        }
    }
}

