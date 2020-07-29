using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int x = 27;
            do
            {
                Console.WriteLine("X = " + x);
                x++;
            } while (x <= 23);*/


            int TimeToSee = 0;

            while (TimeToSee <= 3000)
            {
                Console.Write("Enter a Number : ");
                Console.WriteLine(GetDay(Convert.ToInt32(Console.ReadLine())));
                TimeToSee++;
            }
            Console.ReadLine();
        }
        static string GetDay(int NumDay)
        {
            string dayName;

            switch (NumDay)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid Day Name";
                    break;
            }
            return dayName;
        }
    }
}
