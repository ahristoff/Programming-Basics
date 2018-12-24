using System;

namespace _10_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            Console.WriteLine("Triangle area = {0}", Math.Round(a * h / 2, 2));           
        }
    }
}
