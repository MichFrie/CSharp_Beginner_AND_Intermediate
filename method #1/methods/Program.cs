using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            CV("Alex", 14, "bulgarian");

            Console.ReadLine();
        }

        static void CV(string Name, int age ,string nationality)
        {
            Console.WriteLine("Hello " + Name +".\nYou're " + age + " years old.\n" +"You are "+ nationality + ".");
        }
    }
}
