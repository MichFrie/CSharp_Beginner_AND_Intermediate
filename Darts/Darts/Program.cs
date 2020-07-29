using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{
	class Program
	{
		static void Main(string[] args)
		{
			int TotalPoints = 301;

			string PlayerName = Console.ReadLine();

			int shots = 0;
			int UShots = 0;

			string area = "";
			int points = 0;

			while (TotalPoints >= 1 || area != "Retire")
			{
				area = Console.ReadLine();

				if(area == "Retire")
				{
					break;
				}

				points = int.Parse(Console.ReadLine());

				if (area == "Single")
				{
					if (TotalPoints >= points * 1)
					{
						TotalPoints -= points * 1;
						shots++;
					}
					else
						UShots++;
				}
				else if(area == "Double")
				{
					if (TotalPoints >= points * 2)
					{
						TotalPoints -= points * 2;
						shots++;

					}
					else
						UShots++;
				}
				else if(area == "Triple")
				{
					if (TotalPoints >= points * 3)
					{
						TotalPoints -= points * 3;
						shots++;
					}
					else
						UShots++;

				}
				if (TotalPoints == 0)
				{
					break;
				}
			}

			if(area == "Retire")
			{
				Console.WriteLine($"{PlayerName} retired after {UShots} unsuccessful shots.");
			}

			if (TotalPoints == 0)
			{
				Console.WriteLine($"{PlayerName} won the leg with {shots} shots.");
			}
		}
	}
}
