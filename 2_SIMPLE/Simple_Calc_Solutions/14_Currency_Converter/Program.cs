using System;

namespace _14_Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double cash = double.Parse(Console.ReadLine());
            string EntrCurr = Console.ReadLine();
            string OutputCurr = Console.ReadLine();

            if (EntrCurr == "BGN" && OutputCurr == "USD")
            {
                Console.WriteLine(Math.Round(cash / 1.79549, 2) + " " + OutputCurr);
            }

            if (EntrCurr == "BGN" && OutputCurr == "EUR")
            {
                Console.WriteLine(Math.Round(cash / 1.95583, 2) + " " + OutputCurr);
            }

            if (EntrCurr == "BGN" && OutputCurr == "GBP")
            {
                Console.WriteLine(Math.Round(cash / 2.53405, 2) + " " + OutputCurr);
            }

            if (EntrCurr == "USD" && OutputCurr == "BGN")
            {
                Console.WriteLine(Math.Round(cash * 1.79549, 2) + " " + OutputCurr);
            }

            if (EntrCurr == "USD" && OutputCurr == "EUR")
            {
                Console.WriteLine(Math.Round(cash * 1.79549 / 1.95583, 2) + " " + OutputCurr);
            }
            if (EntrCurr == "USD" && OutputCurr == "GBP")
            {
                Console.WriteLine(Math.Round(cash * 1.79549 / 2.53405, 2) + " " + OutputCurr);
            }

            if (EntrCurr == "GBP" && OutputCurr == "BGN")
            {
                Console.WriteLine(Math.Round(cash * 2.53405, 2) + " " + OutputCurr);
            }

            if (EntrCurr == "GBP" && OutputCurr == "EUR")
            {
                Console.WriteLine(Math.Round(cash * 2.53405 / 1.95583, 2) + " " + OutputCurr);
            }

            if (EntrCurr == "GBP" && OutputCurr == "USD")
            {
                Console.WriteLine(Math.Round(cash * 2.53405 / 1.79549, 2) + " " + OutputCurr);
            }

            if (EntrCurr == "EUR" && OutputCurr == "BGN")
            {
                Console.WriteLine(Math.Round(cash * 1.95583, 2) + " " + OutputCurr);
            }

            if (EntrCurr == "EUR" && OutputCurr == "GBP")
            {
                Console.WriteLine(Math.Round(cash * 1.95583 / 2.53405, 2) + " " + OutputCurr);
            }

            if (EntrCurr == "EUR" && OutputCurr == "USD")
            {
                Console.WriteLine(Math.Round(cash * 1.95583 / 1.79549, 2) + " " + OutputCurr);
            }

        }
    }
}
