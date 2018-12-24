using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_VEGETABLE_BORSE
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceKgVegetables = double.Parse(Console.ReadLine());
            double priceKgFruits = double.Parse(Console.ReadLine());
            double kgVegetable = double.Parse(Console.ReadLine());
            double kgFruits = double.Parse(Console.ReadLine());

            double profitVegetables = priceKgVegetables * kgVegetable;
            double profitFruits = priceKgFruits * kgFruits;

            double allProfitLeva = profitVegetables + profitFruits;

            double allProfitEvro = allProfitLeva / 1.94;

            Console.WriteLine(allProfitEvro);
        }
    }
}
