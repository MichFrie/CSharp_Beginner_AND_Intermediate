using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExercise
{
	class Program
	{
		static void Main(string[] args)
		{
			var names = new Dictionary<string, int>();

			Console.WriteLine("[P/p] for put a user in the list.\n[G/g] for get a user data in the list.\n[exit] to leave.");
			string input = Console.ReadLine();

			while(input != "exit")
			{
				switch(input.ToLower())
				{
					case "p":
						Console.WriteLine();
						Console.Write("Give a username: ");
						string name = Console.ReadLine();
						
						Console.Write("Put a user data: ");
						int data = int.Parse(Console.ReadLine());
						names.Add(name, data);
						Console.WriteLine("Thank you for the information.");
						break;

					case "g":

						Console.WriteLine();
						Console.Write("Give us a name to find th person: ");
						string nameToFind = Console.ReadLine();

						Console.WriteLine($"The user {nameToFind} data is: {names[nameToFind]}");
						break;

					case "exit":
						Environment.Exit(-1);
						break;
					default:
						Console.WriteLine("We couldn't be helpful to you! Goodbye.");
						Console.ReadKey();
						Environment.Exit(-1);
						break;
				}

				Console.WriteLine();
				Console.WriteLine("[P/p] for put a user in the list.\n[G/g] for get a user data in the list.\n[exit] to leave.");
				input = Console.ReadLine();
			}
		}
	}
}
