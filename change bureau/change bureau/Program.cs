using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace change_bureau
{
    class Program
    {
        static void Main(string[] args)
        {
            double lv = 1;
            double euro = 1.95 * lv;
            double bitcoin = 1168 * lv;
            double dolar = 1.76 * lv;
            double ChineseIoan = 0.15 * dolar;

            double BitcoinCount = 1;
            double ChineseIoanCount = 5;
            double commission = 0.05;
            double ChangedEuros = (BitcoinCount*bitcoin + ChineseIoanCount*ChineseIoan)/euro;
            Console.WriteLine(ChangedEuros);

            
            Console.WriteLine(ChangedEuros * commission);
            Console.WriteLine(ChangedEuros - ChangedEuros * commission);
            Console.WriteLine("{0:0.##}", ChangedEuros - ChangedEuros * commission);
            Console.ReadKey();
        }
    }
}
