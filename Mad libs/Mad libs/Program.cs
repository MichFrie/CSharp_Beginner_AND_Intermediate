using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mad_libs
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int FirmNo;

            Console.Write("Name+Surname: ");
            name = Console.ReadLine();
            Console.WriteLine("Good morning  " + name);

            Console.Write("What's your firm No.:");
            FirmNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("No." + FirmNo);

            Console.ReadLine();

        }
    }
}
