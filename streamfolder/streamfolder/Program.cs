using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace streamfolder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int dolars = 0;
            int a = 0;
            ConsoleKeyInfo key = new ConsoleKeyInfo();

            do
            {
                for (long i = 2000000; i >= 0; i--)
                {
                    
                    if (i == 0)
                    {
                        dolars += 1;
                        i = 2000000;
                        Console.WriteLine("Press Enter to safe the dolars!: {0}", dolars);
                        key = Console.ReadKey(true);

                        if (key.Key == ConsoleKey.Enter)
                        {
                            Console.WriteLine("Safed!!");
                            a = 1;
                            break;
                        }
                        else
                        {
                            i = 2000000;
                        }
                    }
                }
                
            }
            while (a == 0); 
            

            if(a == 1)
            {
                using (StreamWriter sw = new StreamWriter(File.Create("D:\\C# codes\\streamfolder\\myfile.txt")))
                {
                    sw.WriteLine(dolars.ToString() + "$");
                    sw.Close();
                }
                File.Open("D:\\C# codes\\streamfolder\\myfile.txt", FileMode.Open);
            }


            
            Console.ReadKey(); 
        }
    }
}
