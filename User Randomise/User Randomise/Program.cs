using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Randomise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int FirstNum, FinalNum;
            Random rnd = new Random();

            Console.Write("Write a start number: ");
            FirstNum = int.Parse(Console.ReadLine());

            Console.Write("Write a final number: ");
            FinalNum = int.Parse(Console.ReadLine());
            if(FinalNum > FirstNum)
            {
                 int NewNum = rnd.Next(FirstNum,FinalNum);
                Console.WriteLine("The random number is: {0}" , NewNum);

                double MiddleNum = (FirstNum + FinalNum) / 2;
                Console.WriteLine( "The middle number is: {0}" , MiddleNum);

                string binary1 = Convert.ToString(FirstNum, 2);
                Console.WriteLine("The binary number of start number is: {0}" , binary1);
                string binary2 = Convert.ToString(FinalNum, 2);
                Console.WriteLine("The binary number of final number is: {0}" , binary2);
                
            }
            else
            {
                Console.WriteLine("The final number is less than first!!!");
            }
        }
    }
}
