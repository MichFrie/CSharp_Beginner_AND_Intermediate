using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Chief chief = new Chief();
            chief.MakeSpecialDish();

            Chief ItalianChief = new ItalianChief();
            ItalianChief.MakeSpecialDish();

            Console.ReadKey();
        }
    }
}
