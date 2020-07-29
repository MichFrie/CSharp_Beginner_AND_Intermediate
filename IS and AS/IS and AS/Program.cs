using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_and_AS
{
    class Program
    {
        class A
        {
            public string ClassName;
            public A(string aClassName)
            {
                ClassName = aClassName;
            }
        }
        class B
        {
            public string ClassName;
            public B(string aClassName)
            {
                ClassName = aClassName;
            }
        }
        static void Main(string[] args)
        {
            object[] ArrayForString =  new object[4];
            ArrayForString[0] = new A("Programming");
            ArrayForString[1] = new B("Sport Curicillum");
            ArrayForString[2] = "Alex";
            ArrayForString[3] = 32421342314.3;

            for (int i = 0; i < ArrayForString.Length; i++)
            {
                string str = ArrayForString[i] as string;
                Console.Write("{0}", i);
                if (str != null)
                {
                    Console.WriteLine(" " + str);
                }
                else
                {
                    Console.WriteLine(" It's not a word!!!");
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            int x, y;
            x = 12;
            y = 21;

            string s = "Say hello";
            Console.WriteLine(s is string ? x : y);
            Console.ReadKey();
        }
    }
}
