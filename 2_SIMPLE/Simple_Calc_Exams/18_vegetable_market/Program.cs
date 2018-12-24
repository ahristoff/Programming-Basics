using System;

namespace _18_vegetable_market
{
    class Program
    {
        static void Main(string[] args)
        {
            double PriceVegetable = double.Parse(Console.ReadLine());
            double PriceFruit = double.Parse(Console.ReadLine());
            double KgVegetable = double.Parse(Console.ReadLine());
            double KgFruit = double.Parse(Console.ReadLine());

            Console.WriteLine((PriceVegetable * KgVegetable + PriceFruit * KgFruit) / 1.94);
        }
    }
}
