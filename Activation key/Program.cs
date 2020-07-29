using System;
using System.Text;

namespace Activation_key
{
	class Program
	{
		static void Main(string[] args)
		{
			StringBuilder key = new StringBuilder();
			key.Append(Console.ReadLine());

			string input;

			while ((input = Console.ReadLine()) != "Generate")
			{
				string[] com = input.Split(">>>");

				if (com[0] == "Contains")
				{
					if (key.ToString().Contains(com[1]))
					{
						Console.WriteLine($"{key} contains {com[1]}");
					}
					else
					{
						Console.WriteLine("Substring not found!");
					}
				}
				else if (com[0] == "Flip")
				{
					if (com[1] == "Upper")
					{
						for (int i = int.Parse(com[2]); i < int.Parse(com[3]); i++)
						{
							if (!char.IsDigit(key[i]))
							{
								key[i] = char.Parse(key[i].ToString().ToUpper());
							}
						}
					}
					else if (com[1] == "Lower")
					{
						for (int i = int.Parse(com[2]); i < int.Parse(com[3]); i++)
						{
							if (!char.IsDigit(key[i]))
							{
								key[i] = char.Parse(key[i].ToString().ToLower());
							}
						}
					}
					Console.WriteLine(key);
				}
				else if (com[0] == "Slice")
				{
					key.Remove(int.Parse(com[1]), int.Parse(com[2]) != 0 ? int.Parse(com[2]) - int.Parse(com[1]) : int.Parse(com[2]) - int.Parse(com[1]) - 1);

					Console.WriteLine(key);
				}
			}
			Console.WriteLine($"Your activation key is: {key}");
		}
	}
}
