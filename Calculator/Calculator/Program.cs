using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number = ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write ("Enter second number = ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The sum = " + (num1 + num2) );
            Console.WriteLine("The diff = " + (num1 - num2) );
            Console.WriteLine("The miltiplication = " + (num1 * num2) );
            Console.WriteLine("The quotient = " + (num1 / num2) );

            Console.ReadLine();
        }
    }
}
