using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraycode_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num of rows");
            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter num of cols");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows,cols];

            for(int row=0 ; row < rows ; row++)
            {
                for(int col=0 ; col < cols ; col++)
                {
                    Console.WriteLine("Matrix is[{0},{1}] = ",row ,col);
                    matrix[row , col] = int.Parse(Console.ReadLine());
                }
            }
            for(int row=0 ; row < matrix.GetLength(0) ; row++)
            {
                for (int col=0 ; col < matrix.GetLength(1) ; col++)
                {
                    Console.Write(" " + matrix[row, col]);
                }
                Console.ReadLine();
            }
        }
    }
}
