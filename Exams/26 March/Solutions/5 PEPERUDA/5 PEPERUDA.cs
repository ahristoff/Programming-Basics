using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_PEPERUDA
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int stars = n - 2;

            for (int i = 1; i <= (int)((n-2)/2); i++)
            {

                Console.WriteLine("{0}\\ /{1}", new string('*',stars),new string('*',stars));
                Console.WriteLine("{0}\\ /{1}", new string('-', stars), new string('-', stars));
            }

            Console.WriteLine("{0}\\ /{1}", new string('*', stars), new string('*', stars));
            Console.WriteLine("{0}@", new string(' ',n-1));
            Console.WriteLine("{0}/ \\{1}", new string('*', stars), new string('*', stars));

            for (int i = 1; i <= (int)((n - 2) / 2); i++)
            {
                Console.WriteLine("{0}/ \\{1}", new string('-', stars), new string('-', stars));
                Console.WriteLine("{0}/ \\{1}", new string('*', stars), new string('*', stars));

            }
        }
    }
}
