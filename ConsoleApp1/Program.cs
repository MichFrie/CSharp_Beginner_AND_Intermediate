using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
	class Submission
	{
		public string username { get; set; }
		public string language { get; set; }
		public uint points { get; set; }

		public Submission(string u, string l, uint p)
		{
			username = u;
			language = l;
			points = p;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, Submission> contest = new Dictionary<string, Submission>();
			Dictionary<string, int> countLanguages = new Dictionary<string, int>();

			string input;

			while ((input = Console.ReadLine()) != "exam finished")
			{
				string[] command = input.Split('-');

				if (command[1] != "banned")
				{
					Submission sub = new Submission(command[0], command[1], uint.Parse(command[2]));

					if (!contest.ContainsKey(command[0]))
					{
						contest.Add(command[0], sub);
					}
					else if (contest[command[0]].points < sub.points)
					{
						contest[command[0]].points = sub.points;
					}

					if (countLanguages.ContainsKey(command[1]))
					{
						countLanguages[command[1]]++;
					}
					else
					{
						countLanguages.Add(command[1], 1);
					} 
				}
				else
				{
					if (contest.ContainsKey(command[0]))
					{
						contest.Remove(command[0]);
					}
				}
			}
			contest = contest.OrderByDescending(c => c.Value.points)
							.ThenBy(c => c.Key)
							.ToDictionary(c => c.Key, c => c.Value);

			Console.WriteLine("Results:");
			foreach (var contestant in contest)
			{
				Console.WriteLine($"{contestant.Key} | {contestant.Value.points}");
			}

			Console.WriteLine("Submissions:");

			countLanguages = countLanguages.OrderByDescending(l => l.Value)
											.ThenBy(l => l.Key)
											.ToDictionary(l => l.Key, l => l.Value);
			foreach (var lang in countLanguages)
			{
				Console.WriteLine($"{lang.Key} - {lang.Value}");
			}
		}
	}
}
