using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anuual fee = ");
            int AnnualFee = int.Parse(Console.ReadLine());
            if(AnnualFee > 0 && AnnualFee <=999)
            {
                double shoes = AnnualFee - AnnualFee * 0.4;
                double outfit = shoes - shoes * 0.2;
                double basketBall = outfit * 0.25;
                double accessories = basketBall * 0.2;

                double total = AnnualFee + outfit + basketBall + accessories + shoes;
                Console.WriteLine("Total amount is: {0:0.00}", total);
            }
            else
            {
                Console.WriteLine("Annual fee is not in the proper amount frame!!! [{0}]" , AnnualFee);
            }
            Console.ReadKey();
        }
    }
}
