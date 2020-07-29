using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace renovation
{
    class Program
    {
        static void Main(string[] args)
        {

            double budget = 1000;
            double floorWidth = 5.55;
            double floorLength = 8.95;
            double TriangleWallLength = 0.90;
            double TriangleHight = 0.85;
            double TilePrice = 13.99;
            double BuilderPrice = 321;
            double fira = 5;

            double FaceOfAFloor = floorLength * floorWidth;
            double FaceOfATriangle = TriangleHight * TriangleWallLength / 2;

            int TilesNeed = Convert.ToInt32(FaceOfAFloor / FaceOfATriangle + fira);
            //Console.WriteLine( "{0:0}", TilesNeed);

            double TilesPrice = TilesNeed * TilePrice;
            double totalAmmount = TilesPrice + BuilderPrice;

            //Console.WriteLine(totalAmmount);

            if(budget > totalAmmount)
            {
                Console.WriteLine("{0:C}lv left", budget - totalAmmount);
            }
            else
            {
                Console.WriteLine("You'll need {0:C}lv more.", totalAmmount - budget );
            }

            Console.ReadKey();

           
        }
    }
}
