using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

namespace Text_Processing_ex
{
	class Program
	{
		
		static void Main(string[] args)
		{
			string[] codes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
			double totalSum = 0;

			for (int i = 0; i < codes.Length; i++)
			{
				string currentCode = codes[i];
				int currentNum = int.Parse(currentCode.Substring(1,currentCode.Length-2));
				double currentResult = 0;

				if (currentCode[0] >= 65 && currentCode[0] <= 90)
				{
					currentResult = currentNum * 1.0 / ( 26 - (26 - (currentCode[0] - 64)) );
				}
				else
				{
					currentResult = currentNum * 1.0 * ( 26 - (26 - (currentCode[0] - 96)) );
				}

				if (currentCode[^1] >= 65 && currentCode[^1] <= 90)
				{
					currentResult -= 26 - (26 - (currentCode[^1] - 64));
				}
				else
				{
					currentResult += 26 - (26 - (currentCode[^1] - 96));

				}
				totalSum += currentResult;
			}
			Console.WriteLine($"{totalSum:f2}");
		}
	}
}
