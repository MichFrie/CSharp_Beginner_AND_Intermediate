using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosh_exercises
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			string[] nums = input.Split(',');

			int max = 0;

			foreach (var num in nums)
			{
				if(int.TryParse(num,out int value))
					if (max < int.Parse(num))
						max = int.Parse(num);
			}

			Console.WriteLine(max);

			Console.ReadKey();
		}
	}
}
