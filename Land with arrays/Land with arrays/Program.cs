using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Land_with_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("How much big do you want to be your land?(rows)");
                int rows = int.Parse(Console.ReadLine());

                Console.Write("How much big do you want to be your land?(columns)");
                int cols = int.Parse(Console.ReadLine());

                int[,] LandArray = new int[rows, cols];

                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        Console.Write("Land[{0},{1}] is ", row, col);
                        LandArray[row, col] = int.Parse(Console.ReadLine());
                    }
                }

                for (int row = 0; row < LandArray.GetLength(0); row++)
                {
                    for (int col = 0; col < LandArray.GetLength(1); col++)
                    {
                        Console.WriteLine("Land[{0},{1}] has " + LandArray[row, col] + " decares", row, col);
                    }
                }

                Console.WriteLine("Do you want to change smt?");

                
               int getrow;
                int getcolumn;
                int value;

                Console.Write("Say which row:");
                getrow = int.Parse(Console.ReadLine());
                Console.Write("Say which column:");
                getcolumn = int.Parse(Console.ReadLine());
                value = LandArray[getrow, getcolumn];
                Console.Write("Give Land[{0},{1}] new value:", getrow, getcolumn);
                value = int.Parse(Console.ReadLine());
                Console.WriteLine("New Land[{0},{1}] decares value is: " + value, getrow, getcolumn);
                Console.WriteLine(" ");

                for (int row = 0; row < LandArray.GetLength(0); row++)
                {
                    for (int col = 0; col < LandArray.GetLength(1); col++)
                    {
                        Console.WriteLine("Old Land[{0},{1}] = " + LandArray[row, col] + " decares", row, col);
                        
                    }
                }
                Console.WriteLine("New Land[{0},{1}] = " + value + " decares", getrow, getcolumn);       
                
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
           
        }
    }
}
