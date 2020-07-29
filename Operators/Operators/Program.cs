using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            int z = 31;
            x = y = 15;
            z = x = y;
            int a = 4;
            int b = 5;

            Console.WriteLine("a & b = " + (a & b));
            Console.WriteLine("a | b = " + (a | b));
            Console.WriteLine("a ^ b = " + (a ^ b));
            Console.WriteLine("~a = " + ~a );*/
            Console.WriteLine("a << 2" + (a << 2));
            Console.WriteLine("a >> 2" + (a >> 2));
            
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
