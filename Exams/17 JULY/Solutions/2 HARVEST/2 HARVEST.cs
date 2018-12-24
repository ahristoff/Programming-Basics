using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_HARVEST
{
    class Program
    {
        static void Main(string[] args)
        {
            double meter = double.Parse(Console.ReadLine());
            double grape = double.Parse(Console.ReadLine());
            double needLiterWein = double.Parse(Console.ReadLine());
            double numerWorker = double.Parse(Console.ReadLine());

            double harvest = meter * grape;
            double getWein = (harvest * 0.4) / 2.5;

            if (getWein < needLiterWein)
            {

                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(needLiterWein - getWein));
            }

            else if(getWein >= needLiterWein)
            {

                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(getWein));
                Console.WriteLine("{0} liters left -> {1} liters per person.",
                    Math.Ceiling(getWein - needLiterWein),
                    Math.Ceiling(Math.Floor(getWein - needLiterWein) / numerWorker));           
            }
        }
    }
}
