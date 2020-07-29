using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
	class Program
	{
		static void Main(string[] args)
		{
			int people = int.Parse(Console.ReadLine());
			int all_bakery = 0;
			double money = 0;

			//price
			double cookies_cost = 1.5;
			double cakes_cost = 7.80;
			double waffles_cost = 2.30;


			for (int i = 0; i < people; i++)
			{
				string name = Console.ReadLine();
				int cookies_amount = 0;
				int cakes_amount = 0;
				int waffles_amount = 0;

				string input = Console.ReadLine();
				while (input != "Stop baking!")
				{
					int amount = int.Parse(Console.ReadLine());
					switch(input)
					{
						case "cookies":
							cookies_amount += amount;
							break;
						case "cakes":
							cakes_amount += amount;
							break;
						case "waffles":
							waffles_amount += amount;
							break;
					}
					input = Console.ReadLine();
				}
				all_bakery += cookies_amount + cakes_amount + waffles_amount;
				money += cookies_amount * cookies_cost + cakes_amount * cakes_cost + waffles_amount * waffles_cost;

				Console.WriteLine($"{name} baked {cookies_amount} cookies, {cakes_amount} cakes and {waffles_amount} waffles.");
			}
			Console.WriteLine($"All bakery sold: {all_bakery}");
			Console.WriteLine("Total sum for charity: {0:0.00} lv.", money);
		}
	}
}
