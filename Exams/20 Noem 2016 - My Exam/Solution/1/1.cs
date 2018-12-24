using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            double footInKg = double.Parse(Console.ReadLine());
            double footDayDog = double.Parse(Console.ReadLine());
            double footDayCat = double.Parse(Console.ReadLine());
            double footDayTor = double.Parse(Console.ReadLine());

            double allFoodDog = days * footDayDog;
           
            double allFoodCat = days * footDayCat;
            
            double allFoodTor = days * footDayTor/1000;
            
            double allFood = allFoodDog + allFoodCat + allFoodTor;

            if (footInKg >= allFood)
            {
                Console.WriteLine("{0} kilos of food left.",Math.Floor(footInKg-allFood));
            }

            else
            {
                Console.WriteLine("{0} more kilos of food are needed.",Math.Ceiling(allFood- footInKg));
            }
        }
    }
}
