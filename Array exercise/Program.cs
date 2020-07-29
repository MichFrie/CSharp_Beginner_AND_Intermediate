using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_exercise
{
	class Program
	{
		static void Main(string[] args)
		{
			var listOfStr = new List<string>();
			string input = "";

			do
			{
				input = Console.Read().ToString();
				if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
				{
					listOfStr.Add(input);
				}
			} while (Console.ReadKey(true).Key == ConsoleKey.Spacebar);

			if(Console.ReadKey(true).Key == ConsoleKey.Enter)
			{
				string[] firstLine = listOfStr.ToArray();
				for (int i = 0; i < firstLine.Length; i++)
				{
					Console.WriteLine(firstLine[i]);
				}
			}
				

			
			
			Console.ReadKey();

		}
	}
}
