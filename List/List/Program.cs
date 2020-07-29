using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<int> ints = new List<int>();
            List<double> doubles = new List<double>();

            while (true)
            {
                int intResult;
                double doubleResult;

                Console.WriteLine("Give a number: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out intResult))
                {
                    ints.Add(intResult);
                }
                else if (double.TryParse(input, out doubleResult))
                {
                    doubles.Add(doubleResult);
                }
                else
                {
                    break;
                }
            }
            Console.Write("You entered {0} ints:", ints.Count);
            foreach (var i in ints)
            {
                Console.Write(" " + i);
            }

            Console.WriteLine();
            Console.Write("You entered {0} doubles:", doubles.Count);
            foreach (var d in doubles)
            {
                Console.Write(" " + d);
            }
            Console.WriteLine();

            Console.WriteLine();

            Console.ReadKey(); 
        }
    }
}
