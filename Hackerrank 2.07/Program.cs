using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Hackerrank_2._07
{
	class Program
	{
        public static int getTotalX(List<int> a, List<int> b)
        {
            int count = 0;

            

            for (int i = a[a.Count - 1]; i <= b[0]; i++)
            {
                bool isNum = true;
                for (int j = 0; j < a.Count; j++)
                {
                    if (i % a[j] != 0)
                    {
                        isNum = false;
                        break;
                    }
                }
                if (isNum)
                {
                    for (int j = 0; j < b.Count; j++)
                    {
                        if (b[j] % i != 0)
                        {
                            isNum = false;
                            break;
                        }
                    }
                }
                if (isNum)
                {
                    count++;
                }
            }
            return count;
        }

        static void Main(string[] args)
		{
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

            int total = getTotalX(arr, brr);

            Console.WriteLine(total);
		}
	}
}
