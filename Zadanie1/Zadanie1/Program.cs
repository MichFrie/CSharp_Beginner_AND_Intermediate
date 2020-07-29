using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            int M , N;
            Console.Write("Give M value = ");
            M = Convert.ToInt32(Console.ReadLine());

            if(M % 2 == 0)
            {
                N = M - 1;
                Console.WriteLine(" " + N);
            }
            if(M % 2 ==1)
            {
                N = M - 2;
                Console.WriteLine(" " + N);
            }
            
            Console.ReadLine();
        }
    }
}
