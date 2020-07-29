using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace trainingMid
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
			List<int> greater = new List<int>();
			double average = 0;
			int sum = 0;

			for (int i = 0; i < nums.Length; i++)
			{
				sum += nums[i];
			}
			average = sum * 1.0 / nums.Length;

			for (int i = 0; i < nums.Length; i++)
			{
				if (nums[i] > average)
				{
					greater.Add(nums[i]);
				}
			}

			greater = greater.OrderByDescending(o => o).ToList();
			if (greater.Count > 0)
			{
				for (int i = 0; i < 5 && i < greater.Count; i++)
				{
					Console.Write(greater[i]+ " ");  
				}
			}
			else
			{
				Console.WriteLine("No");
			}
		}
	}
}
