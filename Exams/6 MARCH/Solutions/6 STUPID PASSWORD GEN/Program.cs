using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_STUPID_PASSWORD_GEN
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int i1 = 1; i1 <= n - 1; i1++)
            {
                for (int i2 = 1; i2 <= n - 1; i2++)
                {
                    for (int i3 = 'a'; i3 < 'a' + l; i3++)
                    {
                        for (int i4 = 'a'; i4 < 'a' + l; i4++)
                        {
                            for (int i5 = Math.Max(i1, i2); i5 <= n; i5++)
                            {
                                Console.Write("{0}{1}{2}{3}{4} ", i1, i2, i3, i4, i5);
                            }
                        }
                    }
                }

            }
            Console.WriteLine();
        }
    }
}
