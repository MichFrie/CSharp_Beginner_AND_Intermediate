using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write your name: ");
            string CustomerName = Console.ReadLine();
            Console.WriteLine("Hello " + CustomerName + "\nHere are some of our new sales and offers for you.\n");

            Hotels hotel1 = new Hotels("San Marina", 300);
            Hotels hotel2 = new Hotels("1001 nights", 470);
            Hotels hotel3 = new Hotels("Borovec", 680);
            Hotels hotel4 = new Hotels("Kosovo", 560);
            Hotels hotel5 = new Hotels("Lincoln", 400);
            Hotels hotel6 = new Hotels("Westerns", 290);
            Hotels hotel7 = new Hotels("Thacians", 710);
            Hotels hotel8 = new Hotels("The Club", 570);
            Hotels hotel9 = new Hotels("Polesna", 320);
            Hotels hotel10 = new Hotels("Alim-Bakr", 650);
            Hotels hotel11 = new Hotels("Royal Life", 800);
            Hotels hotel12 = new Hotels("B&B", 210);


            Console.WriteLine(hotel1.HotelName + "  - " + hotel1.Price + "lv");
            Console.WriteLine(hotel2.HotelName + " - " + hotel2.Price + "lv");
            Console.WriteLine(hotel3.HotelName + "     - " + hotel3.Price + "lv");
            Console.WriteLine(hotel4.HotelName + "      - " + hotel4.Price + "lv");
            Console.WriteLine(hotel5.HotelName + "     - " + hotel5.Price + "lv");
            Console.WriteLine(hotel6.HotelName + "    - " + hotel6.Price + "lv");
            Console.WriteLine(hotel7.HotelName + "    - " + hotel7.Price + "lv");
            Console.WriteLine(hotel8.HotelName + "    - " + hotel8.Price + "lv");
            Console.WriteLine(hotel9.HotelName + "     - " + hotel9.Price + "lv");
            Console.WriteLine(hotel10.HotelName + "   - " + hotel10.Price + "lv");
            Console.WriteLine(hotel11.HotelName + "  - " + hotel11.Price + "lv");
            Console.WriteLine(hotel12.HotelName + "         - " + hotel12.Price + "lv");

            string choice;
            string answer;
            bool doexit = false;
            int price = 0;
            

            ///hotel1///
            do
            {
                Console.WriteLine("\nWhich one would you prefer to stay. Write and book.");


                choice = Console.ReadLine();

                switch (choice)
                {
                    case "San Marina":
                        price = hotel1.Price;
                        break;
                    case "1001 nights":
                      price = hotel2.Price;
                        break;
                    case "Borovec":
                        price = hotel3.Price;
                        break;
                    case "Kosovo":
                        price = hotel4.Price;
                        break;
                    case "Lincoln":
                        price = hotel5.Price;
                        break;
                    case "Westerns":
                        price = hotel6.Price;
                        break;
                    case "Thacians":
                      price = hotel7.Price;
                        break;
                    case "The Club":
                        price = hotel8.Price;
                        break;
                    case "Polesna":
                        price = hotel9.Price;
                        break;
                    case "Alim-Bakr":
                        price = hotel10.Price;
                        break;
                    case "Royal Life":
                        price = hotel11.Price;
                        break;
                    case "B&B":
                        price = hotel12.Price;
                        break;
                }
                Console.WriteLine("Is " + choice + " your choice?");
                answer = Console.ReadLine();
                if (answer == "yes")
                {
                    Console.WriteLine(choice + " is booked. The cost is: " + price + "lv");
                    doexit = true;
                }

            }
            while (doexit == false);
        
           
         
            Console.ReadKey(); 
        }
    }
}
