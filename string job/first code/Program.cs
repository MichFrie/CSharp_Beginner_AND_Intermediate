using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_job
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "John";
            int characterAge = 35;

            Console.WriteLine("His name is " +characterName +".");
            Console.WriteLine("He is "+ characterAge + " years old.");
            Console.WriteLine("He like his name, but he doesn't like being " + characterAge +".");

            characterName = "Mike";
            Console.WriteLine("But what about this man?! His name is " + characterName + ".");

            Console.ReadLine();
        }
    }
}
