using System;

namespace _7_Cristmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n + 1; i++)
            {
                Console.Write(" ");
            }

            Console.WriteLine("|");

            for (int i = 1; i <= n; i++)
            {

                for (int j = 1; j <= n - i; j++)    
                {                                 
                    Console.Write(" ");            
                }

                for (int j = 1; j <= i; j++)        
                {                                    
                    Console.Write("*");              
                }

                Console.Write(" ");
                Console.Write("|");
                Console.Write(" ");

                for (int a = 1; a <= i; a++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
