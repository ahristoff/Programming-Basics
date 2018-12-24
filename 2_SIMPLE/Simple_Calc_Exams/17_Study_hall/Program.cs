using System;

namespace _17_Study_hall
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());

            Console.WriteLine((Math.Truncate((h * 100) / 120) * Math.Truncate(((w * 100) - 100) / 70)) - 3);
        }
    }
}
