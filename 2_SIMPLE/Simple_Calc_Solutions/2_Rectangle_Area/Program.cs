using System;

namespace _2_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            var a = int.Parse(Console.ReadLine());
            var area = a * a;
            Console.WriteLine("Square = " + area);
        }
    }
}
