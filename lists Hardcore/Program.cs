using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace lists_Hardcore
{
	class Program
	{
		static void Main(string[] args)
		{
			string Text = Console.ReadLine();
			StringBuilder text = new StringBuilder(Text);

			List<int> nums = new List<int>();

			for (int i = 0; i < text.Length; i++)
			{
				if (char.IsDigit(text[i]))
				{
					nums.Add(int.Parse(text[i].ToString()));
					text.Remove(i, 1);
					i = -1;
				}
			}

			List<int> take = new List<int>();
			List<int> skip = new List<int>();

			for (int i = 0; i < nums.Count; i++)
			{
				if (i%2==0)
				{
					take.Add(nums[i]);
				}
				else
				{
					skip.Add(nums[i]);
				}
			}
			StringBuilder result = new StringBuilder();

			for (int i = 0; i < take.Count; i++)
			{
				for (int j = 0; j < take[i]; j++)
				{
					if (!string.IsNullOrEmpty(text.ToString()))
					{
						result.Append(text[0]);
						text.Remove(0, 1); 
					}
				}
				if (!string.IsNullOrEmpty(text.ToString()))
				{
					text.Remove(0, skip[i]); 
				}
			}
			Console.WriteLine(result);
		}
	}
}
