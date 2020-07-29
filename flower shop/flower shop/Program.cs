using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flower_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            


            try
            {
                ///explanation///
                Console.WriteLine("During summer or spring the flowers cost :\n\n-Chrysanthemums = 2лв.\n\n-Roses = 4.10лв.\n\n-Tulips = 2.50лв.\n");
                Console.WriteLine("During autumn or winter the flowers cost :\n\n-Chrysanthemums = 3.75лв.\n\n-Roses = 4.50лв.\n\n-Tulips = 4.15лв.\n");
                Console.WriteLine("If it's spring, you recieve 5% discount on tulips, which they need to be\nmore than 7. Besides, in winter you recieve 10% discount on roses.\nOn holiday the price is increased with 15%.");
                Console.WriteLine("If you buy 20 or more flower,you recieve a discount of 20% for the entire bunch.Arrangements cost 2lv.");
                 

                Console.WriteLine("Which season is?(spring,summer,autumn,winter)");
                string season = Console.ReadLine();
                Console.WriteLine("What is the occassion?(feast or funeral)");
                string occasion = Console.ReadLine();

                if (season == "spring" || season == "summer" || season == "autumn" || season == "winter")
                {
                    Console.WriteLine("Is today a holiday?");
                    string Holiday = Console.ReadLine();
                    Console.Write("number of Chrysanthemums:");
                    int BoughtChrysanthemums = Convert.ToInt32(Console.ReadLine());
                    Console.Write("number of Rose:");
                    int BoughtRoses = Convert.ToInt32(Console.ReadLine());
                    Console.Write("number of Tulips:");
                    int BoughtTulips = Convert.ToInt32(Console.ReadLine());
                    int allFlowers = BoughtChrysanthemums + BoughtRoses + BoughtTulips;
                    string occasion2  = "";

                    if (allFlowers % 2 == 1)
                    {
                        occasion2 = "feast";
                    }
                    if (allFlowers % 2 == 0)
                    {
                        occasion2 = "funeral";
                    }
                    if (occasion == occasion2)
                    {
                        
                        double HolidayInc = 0.15;
                        double TulipsDiscount = 0.05;
                        double RosesDiscount = 0.10;
                        double bunchFlowers = 0.20;
                        int arrangement = 2;
                        double total = 0;

                        switch (season)
                        {
                            case "spring":
                                double ChrysanthemumsPrice = 2;
                                double RosesPrice = 4.10;
                                double TulipsPrice = 2.50;

                                total = BoughtChrysanthemums * ChrysanthemumsPrice + BoughtRoses * RosesPrice + BoughtTulips * TulipsPrice;

                                if (BoughtTulips > 7)
                                {
                                    total = total - total * TulipsDiscount;
                                }

                                break;

                            case "summer":
                                double ChrysanthemumsPriceSu = 2;
                                double RosesPriceSu = 4.10;
                                double TulipsPriceSu = 2.50;

                                total = BoughtChrysanthemums * ChrysanthemumsPriceSu + BoughtRoses * RosesPriceSu + BoughtTulips * TulipsPriceSu;

                                break;

                            case "autumn":
                                double ChrysanthemumsPriceAu = 3.75;
                                double RosesPriceAu = 4.50;
                                double TulipsPriceAu = 4.15;

                                total = BoughtChrysanthemums * ChrysanthemumsPriceAu + BoughtRoses * RosesPriceAu + BoughtTulips * TulipsPriceAu;

                                break;

                            case "winter":
                                double ChrysanthemumsPriceWi = 3.75;
                                double RosesPriceWi = 4.50;
                                double TulipsPriceWi = 4.15;

                                total = BoughtChrysanthemums * ChrysanthemumsPriceWi + BoughtRoses * RosesPriceWi + BoughtTulips * TulipsPriceWi;

                                if (BoughtRoses >= 10)
                                {
                                    total = total - total * RosesDiscount;
                                }
                                break;
                        }
                        if (Holiday == "yes" || Holiday == "yea" || Holiday == "of course")
                        {
                            total = total + total * HolidayInc;
                        }
                        if (allFlowers > 20)
                        {
                            total = total - total * bunchFlowers;
                        }
                        total = total + arrangement;
                        Console.WriteLine("The total price is: {0:C}", total);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("The number of flowers doesn't respond to the occasion!");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("There isn't a " + season + " as a season.");
                    Console.ReadKey();
                }
            }
            catch(Exception)
            {
                Console.WriteLine("I couldn't comprehend you!");
                Console.ReadKey();
            }
        }
       
    }
}


/*if (season == "spring" || season == "summer")
{
    double ChrysanthemumsPrice = 2;
    double RosesPrice = 4.10;
    double TulipsPrice = 2.50;

    total = BoughtChrysanthemums * ChrysanthemumsPrice + BoughtRoses * RosesPrice + BoughtTulips * TulipsPrice;
    if (Holiday == "yes" || Holiday == "yea" || Holiday == "of course")
    {
        total = total + total * HolidayInc;
    }

    if (season == "spring")
    {
        if (BoughtTulips > 7)
        {
            total = total - total * TulipsDiscount;
        }
    }

}
if (season == "autumn" || season == "winter")
{
    double ChrysanthemumsPrice = 3.75;
    double RosesPrice = 4.50;
    double TulipsPrice = 4.15;

    total = BoughtChrysanthemums * ChrysanthemumsPrice + BoughtRoses * RosesPrice + BoughtTulips * TulipsPrice;
    if (Holiday == "yes" || Holiday == "yea" || Holiday == "of course")
    {
        total = total + total * HolidayInc;
    }

    if (season == "winter")
    {
        if (BoughtRoses >= 10)
        {
            total = total - total * RosesDiscount;
        }
    }
}*/
