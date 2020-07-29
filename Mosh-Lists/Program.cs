using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh_Lists
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				int[] nums = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);

				if (nums.Length < 5)
				{
					Console.WriteLine("Try again!");
					continue;
				}

				var smallest = new List<int>();
				Array.Sort(nums);

				for (int i = 0; i < nums.Length; i++)
				{
					if (smallest.Count != 3)
					{
						if (!smallest.Contains(nums[i]))
						{
							smallest.Add(nums[i]);
						} 
					}
				}
				
				foreach (var num in smallest)
				{
					Console.Write(num + " ");
				}
				break;
			}

			List<int> lst = new List<int>();

			int a = 1;

			_ = a < 2 ? a = 2 : a = 4;  
			Console.ReadKey();
		}
	}
}
