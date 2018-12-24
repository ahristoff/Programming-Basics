using System;

namespace _3_Inches_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("inches = ");
            var inches = double.Parse(Console.ReadLine());
            var centimeter = 2.54 * inches;
            Console.WriteLine("centimeter = " + centimeter);
        }
    }
}
