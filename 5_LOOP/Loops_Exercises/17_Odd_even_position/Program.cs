using System;

namespace _17_Odd_even_position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double sumEven = 0;
            double sumOdd = 0;

            double EvenMax = int.MinValue;
            double EvenMin = int.MaxValue;
            double OddMin = int.MaxValue;
            double OddMax = int.MinValue;

            for (int i = 1; i <= n; i++)
            {

                double num = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    sumEven = sumEven + num;

                    if (EvenMin > num)
                    {
                        EvenMin = num;
                    }

                    if (EvenMax < num)
                    {
                        EvenMax = num;
                    }
                }

                else if (i % 2 == 1)
                {

                    sumOdd = sumOdd + num;

                    if (OddMin > num)
                    {
                        OddMin = num;
                    }

                    if (OddMax < num)
                    {
                        OddMax = num;
                    }
                }
            }

            Console.WriteLine($"OddSum={sumOdd},");

            if (OddMin == int.MaxValue)
            {
                Console.WriteLine("OddMin=No" + ",");
            }

            else
            {
                Console.WriteLine("OddMin=" + OddMin + ",");
            }

            if (OddMax == int.MinValue)
            {
                Console.WriteLine("OddMax=No" + ",");
            }

            else
            {
                Console.WriteLine("OddMax=" + OddMax + ",");
            }

            Console.WriteLine("EvenSum=" + sumEven + ",");

            if (EvenMin == int.MaxValue)
            {
                Console.WriteLine("EvenMin=No" + ",");
            }

            else
            {
                Console.WriteLine("EvenMin=" + EvenMin + ",");
            }

            if (EvenMax == int.MinValue)
            {
                Console.WriteLine("EvenMax=No");
            }

            else
            {
                Console.WriteLine("EvenMax=" + EvenMax);
            }
        }
    }
}
