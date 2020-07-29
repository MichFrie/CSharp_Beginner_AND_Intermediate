using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymnastics
{
    class Program
    {
        static void Main(string[] args)
        {
            double RussiaPointsWithRibbon = 18.5;
            double RussiaPointsWithHoop = 19.1;
            double RussiaPointsWithRope = 18.6;

            double BulgariaPointsWithRibbon = 19;
            double BulgariaPointsWithHoop = 19.3;
            double BulgariaPointsWithRope = 18.9;

            double ItalyPointsWithRibbon = 18.7;
            double ItalyPointsWithHoop = 18.8;
            double ItalyPointsWithRope = 18.85;

            string nation;
            Console.Write("Which nation:");
            nation = Console.ReadLine();

            string Appliance;
            Console.Write("Appliance:");
            Appliance = Console.ReadLine();

            ///Russia///
            if(nation == "Russia" && Appliance == "ribbon")
            {
                Search("Russia", RussiaPointsWithRibbon, "ribbon");
                
            }
            if (nation == "Russia" && Appliance == "hoop")
            {
                Search("Russia", RussiaPointsWithHoop, "hoop");
                
            }
            if (nation == "Russia" && Appliance == "rope")
            {
                Search("Russia", RussiaPointsWithRope, "rope");
                
            }

            ///Bulgaria///
            if (nation == "Bulgaria" && Appliance == "ribbon")
            {
                Search("Bulgaria", BulgariaPointsWithRibbon, "ribbon");
                
            }                                                                
            if (nation == "Bulgaria" && Appliance == "hoop")                 
            {
                Search("Bulgaria", BulgariaPointsWithHoop, "hoop");
                
            }                                                                
            if (nation == "Bulgaria" && Appliance == "rope")                 
            {
                Search("Bulgaria", BulgariaPointsWithRope, "rope");
               
            }

            ///Italy///
            if (nation == "Italy" && Appliance == "ribbon")
            {
                Search("Italy", ItalyPointsWithRibbon, "ribbon");
                
            }                                                                
            if (nation == "Italy" && Appliance == "hoop")                    
            {
                Search("Italy", ItalyPointsWithHoop, "hoop");
                
            }                                                                
            if (nation == "Italy" && Appliance == "rope")                    
            {
                Search("Italy", ItalyPointsWithRope, "rope");
            }

            Console.ReadKey();
        }

        static void Search(string aNation , double aPoints , string aAppliance)
        {
            int TotalScore = 20;
            double ToMax;

            Console.WriteLine("The team of {0} get {1:0.000} on {2}.", aNation, aPoints, aAppliance);
            ToMax = ((TotalScore - aPoints) / 20) * 100;
            Console.WriteLine("{0:0.00}%", ToMax);
        }
    }
}
