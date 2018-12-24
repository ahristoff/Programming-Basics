using System;

namespace _20_Pipes
{
    class Program
    {
        static void Main(string[] args)
        {
            double V = int.Parse(Console.ReadLine());
            double P1 = int.Parse(Console.ReadLine());
            double P2 = int.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());

            double poolPercent = (int)((((P1 + P2) * H) / V) * 100);
            double pipe1 = (int)((P1 / (P1 + P2)) * 100);
            double pipe2 = (int)((P2 / (P1 + P2)) * 100);

            if ((P1 + P2) * H <= V)
            {
                Console.WriteLine($"The pool is {poolPercent}% full. Pipe 1: {pipe1}%. Pipe 2: {pipe2}%.");
            }

            else if (((P1 + P2) * H > V))
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", H, (P1 + P2) * H - V);     
            }
        }
    }
}
