using System;

namespace _8_Sum_Secunds
{
    class Program
    {
        static void Main(string[] args)
        {
            int sec1 = int.Parse(Console.ReadLine());
            int sec2 = int.Parse(Console.ReadLine());
            int sec3 = int.Parse(Console.ReadLine());

            var secs = sec1 + sec2 + sec3;
            var mins = 0;

            if (secs < 10)
            {
                Console.WriteLine(mins + ":" + "0" + secs);
            }

            else if (secs > 10 && secs < 60)
            {
                Console.WriteLine(mins + ":" + secs);
            }

            else if (secs >= 60 && secs < 120)
            {

                if (secs - 60 >= 10)
                {
                    mins = 1;
                    secs = secs - 60;
                    Console.WriteLine(mins + ":" + secs);
                }

                else
                {
                    mins = 1;
                    secs = secs - 60;
                    Console.WriteLine(mins + ":" + "0" + secs);
                }

            }

            else if (secs >= 120 && secs < 180)
            {

                if (secs - 120 >= 10)
                {
                    mins = 2;
                    secs = secs - 120;
                    Console.WriteLine(mins + ":" + secs);
                }

                else
                {
                    mins = 2;
                    secs = secs - 120;
                    Console.WriteLine(mins + ":" + "0" + secs);
                }
            }
        }
    }
}
