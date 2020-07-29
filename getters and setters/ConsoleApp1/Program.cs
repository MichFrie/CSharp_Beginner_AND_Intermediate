using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");

            Films film1 = new Films("Coral reef", "dog");
            Films film2 = new Films("Evil guy","P");

            Console.WriteLine(film1.Rating);

           Console.ReadKey();
        }
    }
}
