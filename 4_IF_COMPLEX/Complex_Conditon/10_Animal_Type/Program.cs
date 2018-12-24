using System;

namespace _10_Animal_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            switch (name)
            {
                case "dog": Console.WriteLine("mammal"); break;

                case "snake":
                case "tortoise":
                case "crocodile":
                    Console.WriteLine("reptile"); break;

                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
