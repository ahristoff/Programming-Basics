using System;

namespace _19_Tile_repair
{
    class Program
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double L = double.Parse(Console.ReadLine());
            double M = double.Parse(Console.ReadLine());
            double O = double.Parse(Console.ReadLine());

            Console.WriteLine(((N * N) - (M * O)) / (W * L));
            Console.WriteLine(((N * N) - (M * O)) / (W * L) * 0.2);
        }
    }
}
