using System;
using System.Linq;
using System.Text;

namespace Secret_chat
{
	class Program
	{
		static void Main(string[] args)
		{
			StringBuilder message = new StringBuilder(Console.ReadLine());

			string input;

			while ((input = Console.ReadLine()) != "Reveal")
			{
				string[] c = input.Split(":|:");

				if (c[0] == "InsertSpace")
				{
					message = message.Insert(int.Parse(c[1]), " ");
					Console.WriteLine(message);
				}
				else if (c[0] == "Reverse")
				{

					if (message.ToString().Contains(c[1]))
					{
						StringBuilder substring = new StringBuilder();

						for (int i = c[1].Length - 1; i >= 0; i--)
						{
							substring.Append(c[1][i]);
						}
						message.Remove(message.ToString().IndexOf(c[1]), c[1].Length);
						message.Append(substring);
						Console.WriteLine(message);
					}
					else
					{
						Console.WriteLine("error");
					}
					
				}
				else
				{
					message = message.Replace(c[1], c[2]);
					Console.WriteLine(message);
				}
				
			}
			Console.WriteLine($"You have a new text message: {message}");
		}
	}
}
