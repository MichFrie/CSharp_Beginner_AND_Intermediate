using System;
using System.Collections.Generic;
using System.Linq;

namespace ForceBook
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, string> users = new Dictionary<string, string>();
			Dictionary<string, List<string>> sides = new Dictionary<string, List<string>>();

			string input;

			while ((input = Console.ReadLine()) != "Lumpawaroo")
			{
				string[] c;
				if (input.Contains("|"))
				{
					c = input.Split(" | ", StringSplitOptions.RemoveEmptyEntries);
					string side = c[0];
					string username = c[1];
					if (!users.ContainsKey(username))
					{
						users.Add(username, side);
						
					}
					

					if (!sides.ContainsKey(side))
					{
						sides.Add(side, new List<string>());
					}
				}
				else if(input.Contains("->"))
				{
					c = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
					string side = c[1];
					string username = c[0];
					if (!users.ContainsKey(username))
					{
						users.Add(username, side);

					}
					else
					{
						users[username] = side;

					}
					Console.WriteLine($"{username} joins the {side} side!");

					if (!sides.ContainsKey(side))
					{
						sides.Add(side, new List<string>());
					}
					
				}			
			}

			foreach (var user in users)
			{
				sides[user.Value].Add(user.Key);
			}

			sides = sides.OrderByDescending(s => s.Value.Count).ThenBy(s => s.Key).ToDictionary(s => s.Key, s => s.Value);

			foreach (var side in sides)
			{
				if (side.Value.Count > 0)
				{
					Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
					List<string> us = side.Value.OrderBy(n => n).ToList();

					foreach (var user in us)
					{
						Console.WriteLine($"! {user}");
					} 
				}
			}
		}
	}
}
