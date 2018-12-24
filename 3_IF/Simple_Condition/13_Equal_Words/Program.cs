using System;

namespace _13_Equal_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string up = Console.ReadLine().ToLower();
            string down = Console.ReadLine().ToLower();

            if (up == down)
            {
                Console.WriteLine("yes");
            }

            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
