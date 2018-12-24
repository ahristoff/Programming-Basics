using System;

namespace _4_Fruit_or_vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string sort = Console.ReadLine();

            if (sort == "tomato" || sort == "cucumber" || sort == "pepper" || sort == "carrot")
            {
                Console.WriteLine("vegetable");
            }

            else if (sort == "banana" || sort == "apple" || sort == "kiwi" || sort == "cherry " || sort == "lemon" || sort == "grapes")
            {
                Console.WriteLine("fruit");
            }

            else
            {
                Console.WriteLine("unknoun");
            }
        }
    }
}
