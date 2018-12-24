using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_MACH_TICKETS
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string cat = Console.ReadLine();
            double n = double.Parse(Console.ReadLine());

            double moneyTransport;
            double moneyTicket;
            double allMoney;

            if (n <= 4)
            {
                if (cat == "Normal")
                {
                    moneyTransport = budget * 0.25;
                    moneyTicket = 249.99 * n;
                    allMoney = moneyTransport - moneyTicket;

                    if (allMoney>=0)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.",allMoney );
                    }

                    else if (allMoney<0)
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.",Math.Abs(allMoney));
                    }
                }

                else if (cat == "VIP")
                {

                    moneyTransport = budget * 0.25;
                    moneyTicket = 499.99 * n;
                    allMoney = moneyTransport - moneyTicket;

                    if (allMoney >= 0)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", allMoney);
                    }
                    else if (allMoney < 0)
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(allMoney));
                    }
                }
            }

            else if (n >= 5 && n <= 9)
            {

                if (cat == "Normal")
                {
                    moneyTransport = budget * 0.4;
                    moneyTicket = 249.99 * n;
                    allMoney = moneyTransport - moneyTicket;

                    if (allMoney >= 0)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", allMoney);
                    }

                    else if (allMoney < 0)
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(allMoney));
                    }
                }

                else if (cat == "VIP")
                {
                    moneyTransport = budget * 0.4;
                    moneyTicket = 499.99 * n;
                    allMoney = moneyTransport - moneyTicket;

                    if (allMoney >= 0)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", allMoney);
                    }

                    else if (allMoney < 0)
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(allMoney));
                    }
                }
            }

            else if (n >= 10 && n <= 24)
            {

                if (cat == "Normal")
                {

                    moneyTransport = budget * 0.5;
                    moneyTicket = 249.99 * n;
                    allMoney = moneyTransport - moneyTicket;

                    if (allMoney >= 0)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", allMoney);
                    }

                    else if (allMoney < 0)
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(allMoney));
                    }
                }

                else if (cat == "VIP")
                {
                    moneyTransport = budget * 0.5;
                    moneyTicket = 499.99 * n;
                    allMoney = moneyTransport - moneyTicket;

                    if (allMoney >= 0)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", allMoney);
                    }

                    else if (allMoney < 0)
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(allMoney));
                    }
                }
            }

            else if (n >= 25 && n <= 49)
            {

                if (cat == "Normal")
                {

                    moneyTransport = budget * 0.6;
                    moneyTicket = 249.99 * n;
                    allMoney = moneyTransport - moneyTicket;

                    if (allMoney >= 0)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", allMoney);
                    }

                    else if (allMoney < 0)
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(allMoney));
                    }
                }

                else if (cat == "VIP")
                {
                    moneyTransport = budget * 0.6;
                    moneyTicket = 499.99 * n;
                    allMoney = moneyTransport - moneyTicket;

                    if (allMoney >= 0)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", allMoney);
                    }

                    else if (allMoney < 0)
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(allMoney));
                    }
                }
            }

            else if (n >= 50)
            {

                if (cat == "Normal")
                {
                    moneyTransport = budget * 0.75;
                    moneyTicket = 249.99 * n;
                    allMoney = moneyTransport - moneyTicket;

                    if (allMoney >= 0)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", allMoney);
                    }

                    else if (allMoney < 0)
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(allMoney));
                    }
                }

                else if (cat == "VIP")
                {
                    moneyTransport = budget * 0.75;
                    moneyTicket = 499.99 * n;
                    allMoney = moneyTransport - moneyTicket;

                    if (allMoney >= 0)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", allMoney);
                    }

                    else if (allMoney < 0)
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(allMoney));
                    }
                }
            }
        }
    }
}
