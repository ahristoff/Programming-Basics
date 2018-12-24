using System;

namespace _13_Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= (int)(n / 2) - 1; i++)           //first 2 rows above
            {

                Console.Write(new string('*', n - 2));
                Console.Write("\\");
                Console.Write(" ");
                Console.Write("/");
                Console.Write(new string('*', n - 2));
                Console.WriteLine();

                Console.Write(new string('-', n - 2));
                Console.Write("\\");
                Console.Write(" ");
                Console.Write("/");
                Console.Write(new string('-', n - 2));
                Console.WriteLine();
            }

            Console.Write(new string('*', n - 2));                 //last row above
            Console.Write("\\");
            Console.Write(" ");
            Console.Write("/");
            Console.Write(new string('*', n - 2));
            Console.WriteLine();


            Console.Write(new string(' ', n - 1));                  //middle
            Console.Write("@");
            Console.WriteLine(new string(' ', n - 1));


            Console.Write(new string('*', n - 2));                  //first row below
            Console.Write("/");
            Console.Write(" ");
            Console.Write("\\");
            Console.Write(new string('*', n - 2));
            Console.WriteLine();

            for (int i = 1; i <= (int)(n / 2) - 1; i++)             //last 2 rows below
            {

                Console.Write(new string('-', n - 2));
                Console.Write("/");
                Console.Write(" ");
                Console.Write("\\");
                Console.Write(new string('-', n - 2));
                Console.WriteLine();

                Console.Write(new string('*', n - 2));
                Console.Write("/");
                Console.Write(" ");
                Console.Write("\\");
                Console.Write(new string('*', n - 2));
                Console.WriteLine();
            }
        }
    }
}
