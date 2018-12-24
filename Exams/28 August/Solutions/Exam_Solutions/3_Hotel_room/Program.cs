using System;

namespace _3_Hotel_room
{
    class Program
    {
        static void Main(string[] args)
        {

            string month = Console.ReadLine();
            double days = double.Parse(Console.ReadLine());

            double studio = 0;
            double apartment = 0;

            if (month == "May" || month == "October")
            {
                if (days <= 7)
                {
                    studio = 50.0 * days;
                    apartment = 65.0 * days;
                }

                else if (days > 7 && days <= 14)
                {
                    studio = (50 - 50 * 5 / 100.0) * days;
                    apartment = 65.0 * days;
                }

                else if (days > 14)
                {
                    studio = (50 - 50 * 30 / 100.0) * days;
                    apartment = (65 - 65 * 10 / 100.0) * days;
                }
            }

            if (month == "June" || month == "September")
            {

                if (days <= 14)
                {

                    studio = 75.2 * days;
                    apartment = 68.70 * days;
                }

                else if (days > 14)
                {

                    studio = (75.2 - 75.2 * 20 / 100) * days;
                    apartment = (68.70 - 68.70 * 10 / 100) * days;
                }
            }

            if (month == "July" || month == "August")
            {
                if (days <= 14)
                {

                    studio = 76.0 * days;
                    apartment = 77.0 * days;
                }

                else if (days > 14)
                {

                    studio = 76.0 * days;
                    apartment = (77.0 - 77.0 * 10 / 100) * days;
                }
            }

            Console.WriteLine("Apartment: {0:f2} lv.", apartment);
            Console.WriteLine("Studio: {0:f2} lv.", studio);
        }
    }
}
