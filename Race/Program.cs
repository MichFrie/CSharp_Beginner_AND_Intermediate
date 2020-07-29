using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Race
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, int> participants = new Dictionary<string, int>();

			string[] initial = Console.ReadLine().Split(", ");
			foreach (var name in initial)
			{
				participants.Add(name, 0);
			}

			string input;

			while ((input = Console.ReadLine()) != "end of race")
			{
				string name = string.Join("", Regex.Matches(input, @"[A-Za-z]"));
				int sum = Regex.Matches(input, @"[0-9]").ToList().Select(n => int.Parse(n.ToString())).Sum();


				if (participants.ContainsKey(name.ToString()))
				{
					participants[name.ToString()] += sum;
				}
			}

			participants = participants.OrderByDescending(p => p.Value).ToDictionary(k => k.Key, v => v.Value);

			int count = 0;
			foreach (var item in participants)
			{
				count++;
				if (count <= 3)
				{
					switch (count)
					{
						case 1:
							Console.WriteLine($"1st place: {item.Key}");
							break;
						case 2:
							Console.WriteLine($"2nd place: {item.Key}");
							break;
						case 3:
							Console.WriteLine($"3rd place: {item.Key}");
							break;
						default:
							break;
					}
				}
				else
				{
					break;
				}
			}
		}
	}
}
