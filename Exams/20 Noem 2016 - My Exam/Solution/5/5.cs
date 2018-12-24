using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            int s1 = 1;
            int s2 = (2 * n) - 1;

            int s3 = n / 2;
            int s4 = n;

            int s5 = 1;
            int s6 = (2 * n) - 1;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('*', s1), new string('-',s2));
                s1++;
                s2-=2;
            }

            for (int i = 1; i <= (n/3); i++)
            {
                Console.WriteLine("|{0}\\{1}/{0}|",new string('*',s3),new string('*',s4));
                s3++;
                s4 -= 2;
            }
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('-', s5), new string('*', s6));
                s5++;
                s6 -= 2;
            }
        }
    }
}
