using System;
using System.Collections.Generic;

namespace softuni_Parking
{
	class Program
	{
		static void Main(string[] args)
		{
			int count = int.Parse(Console.ReadLine());

			Dictionary<string, string> users = new Dictionary<string, string>();

			for (int i = 0; i < count; i++)
			{
				string[] command = Console.ReadLine().Split();

				if (command[0] == "register")
				{
					if (users.ContainsKey(command[1]))
					{
						Console.WriteLine($"ERROR: already registered with plate number {command[2]}");
					}
					else
					{
						users.Add(command[1], command[2]);
						Console.WriteLine($"{command[1]} registered {users[command[1]]} successfully");
					}
				}
				else
				{
					if (users.ContainsKey(command[1]))
					{
						users.Remove(command[1]);
						Console.WriteLine($"{command[1]} unregistered successfully");
					}
					else
					{
						Console.WriteLine($"ERROR: user {command[1]} not found");
					}
				}
 			}

			foreach (var user in users)
			{
				Console.WriteLine($"{user.Key} => {user.Value}");
			}
		}
	}
}
