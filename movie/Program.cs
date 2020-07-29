using System;
using System.Collections.Generic;
using System.Linq;

namespace movie
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> shelf = Console.ReadLine().Split('&', StringSplitOptions.RemoveEmptyEntries).ToList();

			string input;

			while ((input = Console.ReadLine()) != "Done")
			{
				string[] c = input.Split(" | ", StringSplitOptions.RemoveEmptyEntries);

				if (c[0] == "Add Book")
				{
					if (!shelf.Contains(c[1]))
					{
						shelf.Insert(0, c[1]);
					}
				}
				else if (c[0] == "Take Book")
				{
					if (shelf.Contains(c[1]))
					{
						shelf.Remove(c[1]);
					}
				}
				else if (c[0] == "Swap Books")
				{
					if (shelf.Contains(c[1]) && shelf.Contains(c[2]))
					{
						int index1 = shelf.IndexOf(c[1]);
						int index2 = shelf.IndexOf(c[2]);

						shelf[index1] = c[2];
						shelf[index2] = c[1];
					}
				}
				else if (c[0] == "Insert Book")
				{
					shelf.Add(c[1]);
				}
				else if (c[0] == "Check Book")
				{
					if (int.Parse(c[1]) >= 0 && int.Parse(c[1]) < shelf.Count)
					{
						Console.WriteLine(shelf[int.Parse(c[1])]);
					}
				}
			}
			Console.WriteLine(string.Join(", ", shelf));
		}
	}
}
