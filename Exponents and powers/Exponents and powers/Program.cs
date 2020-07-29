using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exponents_and_powers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b,c;

            Console.Write("Whrite a base number = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Whrite a power number = ");
            b = Convert.ToInt32(Console.ReadLine());
            c = GetPow(a, b);
            Console.WriteLine("The result is = " + c);
            Console.ReadLine();
        }
        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;
            for(int i=0 ; i < powNum ; i++)
            {
                result = result * baseNum;
            }
            return result;
        }
    }
}
