using System;

namespace Honorarium
{
	class Program
	{
		static void Main(string[] args)
		{
			double budget = double.Parse(Console.ReadLine());

			while (budget > 0)
			{
				string name = Console.ReadLine();

				if (name != "ACTION")
				{
					if (name.Length > 15)
					{
						budget -= budget * 0.2;
					}
					else
					{
						double honorarium = double.Parse(Console.ReadLine());

						budget -= honorarium;
					}
				}
				else
				{
					break;
				}
				
			}

			if(0 <= budget)
				Console.WriteLine($"We are left with {budget:f2} leva.");
			else
				Console.WriteLine($"We need {Math.Abs(budget):f2} leva for our actors.");
		}
	}
}
