using System;

namespace _1_Age_and_gender
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = double.Parse(Console.ReadLine());
            var gender = Console.ReadLine();

            if (age < 16)
            {
                if (gender == "m")
                {
                    Console.WriteLine("Master");
                }

                else if (gender == "f")
                {
                    Console.WriteLine("Miss");
                }
            }

            if (age >= 16)
            {

                if (gender == "m")
                {
                    Console.WriteLine("Mr.");
                }

                else if (gender == "f")
                {
                    Console.WriteLine("Ms=");
                }
            }
        }
    }
}
