using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number : ");
            
            Console.WriteLine(GetDay(Convert.ToInt32(Console.ReadLine())));

            Console.ReadLine();
        }

        

    }
}
