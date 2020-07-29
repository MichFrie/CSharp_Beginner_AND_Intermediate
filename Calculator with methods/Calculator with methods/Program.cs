using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_with_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Which activity do you want to use");
            Console.WriteLine("1-sum,2-sub,3-multipy,4-div,5-square,6-partition with remainder(IT),7-Power");
            x = Convert.ToInt32(Console.ReadLine());

            if (x == 1)
            {
                Console.Write("Enter a number = ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter a second number = ");
                double b = Convert.ToDouble(Console.ReadLine());
                double c = sum(a, b);
                Console.WriteLine("Result = " + c);
                Console.ReadLine();
            }

            if (x == 2)
            {
                Console.Write("Enter a number = ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter a second number = ");
                double b = Convert.ToDouble(Console.ReadLine());
                double c = sub(a, b);
                Console.WriteLine("Result = " + c);
                Console.ReadLine();
            }

            if (x == 3)
            {
                Console.Write("Enter a number = ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter a second number = ");
                double b = Convert.ToDouble(Console.ReadLine());
                double c = multiply(a, b);
                Console.WriteLine("Result = " + c);
                Console.ReadLine();
            }

            if (x == 4)
            {
                Console.Write("Enter a number = ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter a second number = ");
                double b = Convert.ToDouble(Console.ReadLine());
                double c = div(a, b);
                Console.WriteLine("Result = " + c);
                Console.ReadLine();
            }

            if (x == 5)
            {
                Console.Write("Enter a number = ");
                double a = Convert.ToDouble(Console.ReadLine());
                double c = square(a);
                Console.WriteLine("Result = " + c);
                Console.ReadLine();
            }

            if (x == 6)
            {
                Console.Write("Enter a number = ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter a second number = ");
                double b = Convert.ToDouble(Console.ReadLine());
                double c = PartitionWithRemainder(a, b);
                Console.WriteLine("Result = " + c);
                Console.ReadLine();
            }
            if (x == 7)
            {
                Console.Write("Write a base number = ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Write a power number = ");
                double b = Convert.ToDouble(Console.ReadLine());
                double c = GetPow( a , b );
                Console.WriteLine("The result is = " + c);
                Console.ReadLine();
            }
        }

        static double sum(double num1, double num2)
        {
            double result;

            result = num1 + num2;

            return result;
        }

        static double sub(double num1, double num2)
        {
            double result;

            result = num1 - num2;

            return result;
        }

        static double multiply(double num1, double num2)
        {
            double result;

            result = num1 * num2;

            return result;
        }

        static double div(double num1, double num2)
        {
            double result;

            result = num1 / num2;

            return result;
        }

        static double square(double num1)
        {
            double result;

            result = num1 * num1;

            return result;
        }

        static double PartitionWithRemainder(double num1, double num2)
        {
            double result;

            result = num1 % num2;

            return result;
        }
        static double GetPow(double baseNum, double powNum)
        {
            double result = 1;
            for (int i = 0; i < powNum; i++)
            {
                result = result * baseNum;
            }
            return result;
        }
    }
}