using System;
using System.Collections.Generic;


class Solution
{
	static string kangaroo(int x1, int v1, int x2, int v2)
	{
		int diff = Math.Abs(x1 - x2);
		while (true)
		{
			x1 += v1;
			x2 += v2;

			int tempDiff = Math.Abs(x1 - x2);

			if (tempDiff >= diff)
			{
				return "NO";
				
			}
			else if (x1 == x2)
			{
				
				return "YES";
				
			}
			else 
			{
				continue;
			}
		}
	}
	public static void Main(string[] args)
	{
		string[] x1V1X2V2 = Console.ReadLine().Split(' ');

		int x1 = Convert.ToInt32(x1V1X2V2[0]);

		int v1 = Convert.ToInt32(x1V1X2V2[1]);

		int x2 = Convert.ToInt32(x1V1X2V2[2]);

		int v2 = Convert.ToInt32(x1V1X2V2[3]);

		string result = kangaroo(x1, v1, x2, v2);
		Console.WriteLine(result);
		Console.ReadKey();
	}
}
