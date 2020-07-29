using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the fibonacci sequence!");
            ulong[] fs = new ulong[101];
            fs[0] = 1;
            fs[1] = 1;

            Console.WriteLine(fs[0]);
            Console.WriteLine(fs[1]);
            for (long i = 2; i < fs.Length; i++)
            {
                fs[i] = fs[i - 1] + fs[i - 2];
                
                
                Console.WriteLine(fs[i] + " - " + i);
            }

            Console.ReadKey();
        }
    }
}
