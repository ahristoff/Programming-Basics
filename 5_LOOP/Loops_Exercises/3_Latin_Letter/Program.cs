using System;

namespace _3_Latin_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Latin alphabet:");

            for (var i = 'a'; i <= 'z'; i++)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
        }
    }
}
