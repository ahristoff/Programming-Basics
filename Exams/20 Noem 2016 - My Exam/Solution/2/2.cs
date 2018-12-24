using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceSk = double.Parse(Console.ReadLine());
            double priceZaz = double.Parse(Console.ReadLine());
            double kgPal = double.Parse(Console.ReadLine());
            double kgSaf = double.Parse(Console.ReadLine());
            double kgMussels = double.Parse(Console.ReadLine());

            double pricePal = priceSk + priceSk * 0.6;
            double sumPal = kgPal * pricePal;

            double priseSaf = priceZaz + priceZaz * 0.8;
            double sumSaf = kgSaf * priseSaf;

            double sumMidi = kgMussels * 7.5;

            double allPr = sumPal + sumSaf + sumMidi;

            Console.WriteLine("{0:f2}",allPr);
        }
    }
}
