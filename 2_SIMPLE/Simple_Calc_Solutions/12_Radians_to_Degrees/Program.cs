using System;

namespace _12_Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double radian = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round((radian * 180) / Math.PI));
        }
    }
}
