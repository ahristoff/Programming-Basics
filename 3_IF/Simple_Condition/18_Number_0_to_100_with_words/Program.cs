using System;

namespace _18_Number_0_to_100_with_words
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var lastDigit = n % 10;
            string lastDigitName = null;
            string numberName = null;

            if (n < 0 || n > 100)
            {
                numberName = "invalid number";
            }

            else if (n == 0)
            {
                numberName = "zero";
            }

            else if (lastDigit == 1)
            {
                lastDigitName = " one";
            }

            else if (lastDigit == 2)
            {
                lastDigitName = " two";
            }

            else if (lastDigit == 3)
            {
                lastDigitName = " Three";
            }

            else if (lastDigit == 4)
            {
                lastDigitName = " four";
            }

            else if (lastDigit == 5)
            {
                lastDigitName = " five";
            }

            else if (lastDigit == 6)
            {
                lastDigitName = " six";
            }

            else if (lastDigit == 7)
            {
                lastDigitName = " seven";
            }

            else if (lastDigit == 8)
            {
                lastDigitName = " eight";
            }

            else if (lastDigit == 9)
            {
                lastDigitName = " nine";
            }

            else if (n > 0 && n < 10)
            {
                numberName = lastDigitName;
            }

            else if (n == 10)
            {
                numberName = "ten";
            }

            else if (n == 11)
            {
                numberName = "eleven";
            }

            else if (n == 12)
            {
                numberName = "twelve";
            }

            else if (n == 13)
            {
                numberName = "thirteen";
            }

            else if (n == 15)
            {
                numberName = "fifteen";
            }

            else if (n == 14 || (n > 15 && n < 20))
            {
                numberName = lastDigitName + "teen";
            }

            else if (n >= 20 && n < 30)
            {
                numberName = "twenty" + lastDigitName;
            }

            else if (n >= 30 && n < 40)
            {
                numberName = "thirty" + lastDigitName;
            }

            else if (n >= 40 && n < 50)
            {
                numberName = "fourty" + lastDigitName;
            }

            else if (n >= 50 && n < 60)
            {
                numberName = "fifty" + lastDigitName;
            }

            else if (n >= 60 && n < 70)
            {
                numberName = "sixty" + lastDigitName;
            }
            
            else if (n >= 70 && n < 80)
            {
                numberName = "seventy" + lastDigitName;
            }

            else if (n >= 80 && n < 90)
            {
                numberName = "eighty" + lastDigitName;
            }

            else if (n >= 90 && n < 100)
            {
                numberName = "ninety" + lastDigitName;
            }

            else if (n == 100)
            {
                numberName = "one hundred";
            }

            Console.WriteLine(numberName);
        }
    }
}
