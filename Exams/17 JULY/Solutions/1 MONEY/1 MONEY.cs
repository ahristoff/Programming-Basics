using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_MONEY
{
    class Program
    {
        static void Main(string[] args)
        {
            double bitcount = double.Parse(Console.ReadLine());
            double china = double.Parse(Console.ReadLine());
            double comiss = double.Parse(Console.ReadLine());

            double lervaForBitcount = bitcount * 1168;
            double levaForChina = china * 0.15 * 1.76;

            double allLeva = lervaForBitcount + levaForChina;

            double evro = (allLeva - allLeva * 0.01 * comiss) / 1.95;

            Console.WriteLine(evro);
        }
    }
}
