using System;

namespace _9_Vowel_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string vowel = Console.ReadLine();

            var sum = 0;

            for (int i = 0; i < vowel.Length; i++)
            {

                if (vowel[i] == 'a')
                {
                    sum += 1;
                }

                else if (vowel[i] == 'e')
                {
                    sum += 2;
                }

                else if (vowel[i] == 'i')
                {
                    sum += 3;
                }

                else if (vowel[i] == 'o')
                {
                    sum += 4;
                }

                else if (vowel[i] == 'u')
                {
                    sum += 5;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
