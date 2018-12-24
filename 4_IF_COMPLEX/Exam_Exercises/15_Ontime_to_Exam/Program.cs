using System;

namespace _15_Ontime_to_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var exHour = double.Parse(Console.ReadLine());
            var exMin = double.Parse(Console.ReadLine());
            var arrHour = double.Parse(Console.ReadLine());
            var arrMin = double.Parse(Console.ReadLine());

            var diffLate = (arrHour * 60 + arrMin) - (exHour * 60 + exMin);
            var diffEarly = (exHour * 60 + exMin) - (arrHour * 60 + arrMin);

            if (exHour * 60 + exMin < arrHour * 60 + arrMin)
            {

                if (diffLate > 0 && diffLate < 60)
                {
                    Console.WriteLine($"Late {diffLate} minutes after the start");
                }

                else if (diffLate >= 60)
                {

                    if (diffLate % 60 > 9)
                    {
                        Console.WriteLine($"Late {(int)(diffLate / 60)}:{diffLate % 60} hours after the start");
                    }

                    else if (diffLate % 60 <= 9)
                    {
                        Console.WriteLine($"Late {(int)(diffLate / 60)}:0{diffLate % 60} hours after the start");
                    }
                }
            }

            else if (exHour * 60 + exMin > arrHour * 60 + arrMin)
            {

                if (diffEarly > 0 && diffEarly <= 30)
                {
                    Console.WriteLine("On Time {0} minutes before the start", diffEarly);
                }

                else if (diffEarly > 30 && diffEarly < 60)
                {
                    Console.WriteLine("Early {0} minutes before the start", diffEarly);
                }

                else if (diffEarly >= 60)
                {

                    if (diffEarly % 60 <= 9)
                    {
                        Console.WriteLine($"Early {(int)(diffEarly / 60)}:0{diffEarly % 60} hours before the start");
                    }

                    else if (diffEarly % 60 > 9)
                    {
                        Console.WriteLine($"Early {(int)(diffEarly / 60)}:{diffEarly % 60} hours before the start");
                    }
                }
            }

            else if (exHour * 60 + exMin == arrHour * 60 + arrMin)
            {
                Console.WriteLine("On Time");
            }
        }
    }
}
