using System;
using System.Numerics;


namespace Data_types_and_Variables
{
	class Program
	{
		static void Main(string[] args)
		{
            int count = int.Parse(Console.ReadLine());
            bool special = false;

            for (int i = 1; i <= count; i++)
            {
                int sum = 0;

                int current = i;
                while (current > 0)
                {
                    sum += current % 10;
                    current = current / 10;
                }
                special = (sum == 5) || (sum == 7) || (sum == 11);

                Console.WriteLine("{0} -> {1}", i, special);
            }


        }
    }
}
