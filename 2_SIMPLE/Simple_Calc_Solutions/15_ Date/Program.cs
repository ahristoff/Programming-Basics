using System;

namespace _15__Date
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string format = "ddMMyyyy";
            DateTime birthday = DateTime.ParseExact(input, format, null);
            birthday = birthday.AddDays(999);

            Console.WriteLine(birthday.ToString("dd/MMM/yy"));
        }
    }
}
