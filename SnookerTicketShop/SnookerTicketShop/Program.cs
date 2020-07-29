using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnookerTicketShop
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string TypeOfTicket;
            string Stage;

            Console.WriteLine("Which match you want to buy for?");
            Stage = Console.ReadLine();

            Console.WriteLine("Which type of ticket do you want to buy?");
            TypeOfTicket = Console.ReadLine();

            double PriceForOneTicket;

            switch (Stage)
            {
                case ("Quarter final"):
                    if (TypeOfTicket == "Standart")
                    {
                        PriceForOneTicket = 55.50;
                        TotalTicketPrice(PriceForOneTicket);
                    }
                    else if (TypeOfTicket == "Premium")
                    {
                        PriceForOneTicket = 105.20;
                        TotalTicketPrice(PriceForOneTicket);
                    }
                    else if (TypeOfTicket == "VIP")
                    {
                        PriceForOneTicket = 118.90;
                        TotalTicketPrice(PriceForOneTicket);
                    }
                    break;

                case ("Semi final"):
                    if (TypeOfTicket == "Standart")
                    {
                        PriceForOneTicket = 75.88;
                        TotalTicketPrice(PriceForOneTicket);
                    }
                    else if (TypeOfTicket == "Premium")
                    {
                        PriceForOneTicket = 125.22;
                        TotalTicketPrice(PriceForOneTicket);
                    }
                    else if (TypeOfTicket == "VIP")
                    {
                        PriceForOneTicket = 300.40;
                        TotalTicketPrice(PriceForOneTicket);
                    }
                    break;

                case ("Final"):
                    if (TypeOfTicket == "Standart")
                    {
                        PriceForOneTicket = 110.10;
                        TotalTicketPrice(PriceForOneTicket);
                    }
                    else if (TypeOfTicket == "Premium")
                    {
                        PriceForOneTicket = 160.66;
                        TotalTicketPrice(PriceForOneTicket);
                    }
                    else if (TypeOfTicket == "VIP")
                    {
                        PriceForOneTicket = 400;
                        TotalTicketPrice(PriceForOneTicket);
                    }
                    break;
            }
        }

        static void TotalTicketPrice(double TicketPrice)
        {
            Console.WriteLine();
            Console.WriteLine("How many tickets do you demand?");
            int number = int.Parse(Console.ReadLine());

            double Total = TicketPrice * number;

            if (Total > 4000)
            {
                Total = Total * 0.75;
                Total -= 40;
            }
            else if (Total > 2500 && Total < 4000)
            {
                Total = Total * 0.90;
            }

            string Pic;

            Console.Write("Do you want pic with the trophy: ");
            Pic = Console.ReadLine();

            switch (Pic)
            {
                case "yes":
                    Total += 40;
                    Console.WriteLine("Ok.All cost {0:C}", Total);
                    break;

                case "no":
                    Console.WriteLine("Ok.All cost {0:C}", Total);
                    break;
            }
            Console.ReadKey();
        }
    }
}
