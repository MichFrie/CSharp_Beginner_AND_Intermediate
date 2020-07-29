using System;
using System.Collections.Generic;
using System.Linq;

namespace Pirates
{
	class City
	{
		public int population;
		public int gold;

		public City(int p, int g)
		{ 
			population = p;
			gold = g;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, City> map = new Dictionary<string, City>();
			string input;
		
			while ((input = Console.ReadLine()) != "Sail")
			{
				string[] c = input.Split("||");
				if (map.ContainsKey(c[0]))
				{
					map[c[0]].population += int.Parse(c[1]);
					map[c[0]].gold += int.Parse(c[2]);
				}
				else
				{
					map.Add(c[0], new City(int.Parse(c[1]), int.Parse(c[2])));
				}
			}

			while ((input = Console.ReadLine()) != "End")
			{
				string[] c = input.Split("=>");

				if (c[0] == "Plunder")
				{
					map[c[1]].population -= int.Parse(c[2]);
					map[c[1]].gold -= int.Parse(c[3]);
					Console.WriteLine($"{c[1]} plundered! {c[3]} gold stolen, {c[2]} citizens killed.");
					if (map[c[1]].population <= 0 || map[c[1]].gold <= 0)
					{
						map.Remove(c[1]);
						Console.WriteLine($"{c[1]} has been wiped off the map!");
					}
				}
				else
				{
					if (int.Parse(c[2]) < 0)
					{
						Console.WriteLine("Gold added cannot be a negative number!");
					}
					else
					{
						map[c[1]].gold += int.Parse(c[2]);
						Console.WriteLine($"{c[2]} gold added to the city treasury. {c[1]} now has {map[c[1]].gold} gold.");
					}
				}
			}

			map = map.OrderByDescending(city => city.Value.gold)
						.ThenBy(city => city.Key)
						.ToDictionary(k => k.Key, v => v.Value);
			if (map.Count > 0)
			{
				Console.WriteLine($"Ahoy, Captain! There are { map.Count } wealthy settlements to go to:");

				foreach (var city in map)
				{
					Console.WriteLine($"{city.Key} -> Population: {city.Value.population} citizens, Gold: {city.Value.gold} kg");
				} 
			}
			else
			{
				Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
			}
		}
	}
}
