using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace break_and_continue
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            for (int i = 0; i < 10; i++)
            {
                if (a > 50)
                    break; // or continue;
                Console.WriteLine("Hello World!");
            }

           
            Console.ReadKey();
        }
    }
}
