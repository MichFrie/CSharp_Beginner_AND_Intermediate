using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_and_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num = rnd.Next( 1 , 13 );

            if (num <= 6)
            {
                Console.WriteLine("The num is {0}", num);
                Console.WriteLine("The local time is: {0}", DateTime.Now);
            }
            else
            {
                Console.WriteLine("The num is {0}", num);
                Console.WriteLine("The UTC time is: {0}", DateTime.UtcNow);
            }
            Console.ReadKey();
        }
    }
}
