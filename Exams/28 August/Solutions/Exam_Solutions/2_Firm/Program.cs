using System;

namespace _2_Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            double hours = double.Parse(Console.ReadLine());
            double workDay = double.Parse(Console.ReadLine());
            double countWorker = double.Parse(Console.ReadLine());

            double workHours = (workDay - workDay * 10 / 100) * 8;

            double w = workDay * countWorker * 2;

            double allHours = (int)(w + workHours);

            if (allHours >= hours)
            {
                Console.WriteLine("Yes!{0} hours left.", allHours - hours);
            }

            if (hours > allHours)
            {
                Console.WriteLine("Not enough time!{0} hours needed.", hours - allHours);
            }
        }
    }
}
