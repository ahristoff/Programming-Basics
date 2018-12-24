using System;

namespace _16_Time_15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {

            var hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            if (hours + 1 > 23 && minutes + 15 >= 60)
            {
                hours = -1;
            }

            if (minutes + 15 < 60)
            {
                Console.WriteLine(hours + ":" + (minutes + 15));
            }

            if (minutes + 15 >= 60 && minutes + 15 < 70)
            {
                Console.WriteLine(hours + 1 + ":" + "0" + ((minutes + 15) - 60));
            }

            if (minutes + 15 >= 70)
            {
                Console.WriteLine(hours + 1 + ":" + ((minutes + 15) - 60));
            }
        }
    }
}
