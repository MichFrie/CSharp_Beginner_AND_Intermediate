using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_1
{
	class Program
	{
		static void Main(string[] args)
		{
			string input;

			Dictionary<string, int> users = new Dictionary<string, int>();

			while ((input = Console.ReadLine()) != "Log out")
			{
				string[] command = input.Split(':');

				switch (command[0])
				{
					case "New follower":
						
						if(!users.ContainsKey(command[1]))
						{
							users.Add(command[1], 0);
						}
						else
						{
							continue;
						}
						break;

					case "Like":

						int likes = int.Parse(command[2]);

						if (users.ContainsKey(command[1]))
						{
							users.TryGetValue(command[1], );
						}
						break;

					default:
						break;
				}
			}
			
		}
	}
}
