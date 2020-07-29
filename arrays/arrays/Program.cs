using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friends = new string[3];
            friends[0] = "Jim";
            friends[1] = "Anne";
            friends[2] = "Christian";
            Console.WriteLine(friends[0]+"\n"+friends[1]+"\n"+friends[2]);
            Console.ReadLine();
        }
    }
}
