using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari
{
	class Program
	{
		static void Main(string[] args)
		{
			//Console.Write("Your budget: ");
			double budget = double.Parse(Console.ReadLine());

			double fuelPrice = 2.10;
			//Console.Write("Fuel you need: ");
			double fuelNeed = double.Parse(Console.ReadLine());

			double fuelCost = fuelNeed * fuelPrice;

			int GuideCost = 100;

			double InitialCost = GuideCost + fuelCost;

			//Console.Write("Which day of the weekend is: ");
			string day = Console.ReadLine();

			double Total = 0;

			if(day == "Saturday")
			{
				Total = InitialCost * 0.9;
			}
			else if(day == "Sunday")
			{
				Total = InitialCost * 0.8;
			}

			if (budget >= Total)
			{
				double remain = budget - Total;

				Console.WriteLine("Safari time! Money left: {0:0.00} lv.", remain);
			}
			else if(budget < Total)
			{
				double MoneyNeed = Total - budget;

				Console.WriteLine("Not enough money! Money needed: {0:0.00} lv.", MoneyNeed);
			}

			Console.ReadKey(); 
		}
	}
}
