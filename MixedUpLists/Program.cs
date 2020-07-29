using System;
using System.Collections.Generic;
using System.Linq;

namespace MixedUpLists
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> nums = Console.ReadLine().Split('@').Select(int.Parse).ToList();

			string input;
			int cupidIndex = 0;
			while ((input = Console.ReadLine()) != "Love!")
			{
				string[] c = input.Split();
				int jumpLength = int.Parse(c[1]);
				cupidIndex += jumpLength;
				if (cupidIndex >= nums.Count)
				{
					cupidIndex = 0;
				}

				if (nums[cupidIndex] - 2 == 0)
				{
					Console.WriteLine($"Place {cupidIndex} has Valentine's day.");
					nums[cupidIndex] -= 2;
				}
				else if (nums[cupidIndex] == 0)
				{
					Console.WriteLine($"Place {cupidIndex} already had Valentine's day.");
				}
				else
				{
					nums[cupidIndex] -= 2;
				}
				
			}
			Console.WriteLine($"Cupid's last position was {cupidIndex}.");
			bool all0 = true;
			int didnt = 0;
			for (int i = 0; i < nums.Count; i++)
			{
				if (nums[i] != 0)
				{
					all0 = false;
					didnt++;
				}
			}
			if (all0)
			{
				Console.WriteLine($"Mission was successful.");
			}
			else
			{
				Console.WriteLine($"Cupid has failed {didnt} places.");
			}
		}
	}
}
