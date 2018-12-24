using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PIPE_IN_POOL
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume = double.Parse(Console.ReadLine());
            double flow1Pipe = double.Parse(Console.ReadLine());
            double flow2Pipe = double.Parse(Console.ReadLine());
            double hoursAbsent = double.Parse(Console.ReadLine());


            if (volume >= (flow1Pipe+ flow2Pipe)* hoursAbsent)
            {
                double full = (((flow1Pipe + flow2Pipe) * hoursAbsent) / volume) * 100;
                double p1 = ((flow1Pipe * hoursAbsent) / ((flow1Pipe + flow2Pipe) * hoursAbsent)) * 100;
                double p2 = ((flow2Pipe * hoursAbsent) / ((flow1Pipe + flow2Pipe) * hoursAbsent)) * 100;

                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",(int)(full),(int)(p1),(int)(p2));
            }

            if (volume < (flow1Pipe + flow2Pipe) * hoursAbsent)
            {

                double overFlow = (flow1Pipe + flow2Pipe) * hoursAbsent - volume;

                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hoursAbsent,overFlow);
            }
        }
    }
}
