using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easter_Competition
{
	class Program
	{
		static void Main(string[] args)
		{
			int count = int.Parse(Console.ReadLine());
			string bestBakerName = "";
			int bestBakerPoints = 0;

			for (int i = 0; i < count; i++)
			{
				string bakerName = Console.ReadLine();
				int points = 0;
				string command = Console.ReadLine();

				while ("Stop" != command)
				{
					points += int.Parse(command);
					command = Console.ReadLine();
				}

				Console.WriteLine($"{bakerName} has {points} points.");
				if (points > bestBakerPoints)
				{
					bestBakerName = bakerName;
					bestBakerPoints = points;
					Console.WriteLine($"{bakerName} is the new number 1!");
				}
			}
			Console.WriteLine($"{bestBakerName} won competition with {bestBakerPoints} points!");
		}
	}
}
