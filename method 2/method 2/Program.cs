using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number to square: ");
            Console.WriteLine(MathLesson(Convert.ToInt32(Console.ReadLine())));
            Console.ReadLine();
        }

        static int MathLesson(int square)
        {
            int result = square * square;
            return result;
        }
    }
}
