using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());

            int c = 0;

            for (int i = 1; i <= n1; i++)
            {

                for (int j = 1; j <= n2; j++)
                {

                    c++;

                    if (c <= max)
                    {
                        Console.Write("({0} <-> {1}) ", i, j);
                    }
                                         
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
