using System;
using System.Collections.Generic;
using System.Linq;

namespace List_ex
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
			int maxCap = int.Parse(Console.ReadLine());

			string input = "";
			while ((input = Console.ReadLine()) != "end")
			{
				string[] comm = input.Split();

				if (comm[0] == "Add")
				{
					nums.Add(int.Parse(comm[1]));
				}
				else
				{
					int i;
					for ( i = 0; i < nums.Count; i++)
					{
						if (nums[i] + int.Parse(comm[0]) <= maxCap)
						{
							nums[i] += int.Parse(comm[0]);
							break;
						}
					}
					if (i == nums.Count - 1)
					{
						nums.Add(int.Parse(comm[0]));
					}
				}
			}
			Console.WriteLine(string.Join(" ", nums));
		}
	}
}
