using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] FirstArray ={
                {12,13},
                {21,31},
                {46,64}
            };
            //int[,] FirstArray = new int[2,3];2-rows , 3-colums
            Console.WriteLine(FirstArray[0,1]);//13
            Console.ReadLine();
        }
    }
}
