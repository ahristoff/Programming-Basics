using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_TRAINING_LAB
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());


            double absLength = Math.Truncate(length / 1.2);
            double absWidth = Math.Truncate((width - 1) / 0.7);

            double area = (absLength * absWidth) - 3;

            Console.WriteLine(area);
        }
    }
}
