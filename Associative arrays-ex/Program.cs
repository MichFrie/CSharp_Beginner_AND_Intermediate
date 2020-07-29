using System;
using System.Collections.Generic;
using System.Linq;

namespace Associative_arrays_ex
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, int> materials = new Dictionary<string, int>();
			materials.Add("shards", 0);
			materials.Add("fragments", 0);
			materials.Add("motes", 0);
			Dictionary<string, int> junk = new Dictionary<string, int>();

			string[] input;
			bool ready = false;
			while(true)
			{
				input = Console.ReadLine().Split();

				for (int i = 0; i < input.Length; i+=2)
				{
					int quantity = int.Parse(input[i]);
					string materialName = input[i + 1];

					if (materials.ContainsKey(materialName.ToLower()))
					{
						materials[materialName.ToLower()] += quantity;
					}
					else
					{
						if (junk.ContainsKey(materialName.ToLower()))
						{
							junk[materialName.ToLower()] += quantity;
						}
						else
						{
							junk.Add(materialName.ToLower(), quantity);
						}
					}

					if (materials["shards"] >= 250)
					{
						Console.WriteLine($"Shadowmourne obtained!");
						materials["shards"] -= 250;
						ready = true;
						break;
					}
					else if (materials["fragments"] >= 250)
					{
						Console.WriteLine($"Valanyr obtained!");
						materials["fragments"] -= 250;
						ready = true;
						break;
					}
					else if (materials["motes"] >= 250)
					{
						Console.WriteLine($"Dragonwrath obtained!");
						materials["motes"] -= 250;
						ready = true;
						break;
					}
				}
				if (ready)
					break;
			}

			materials = materials.OrderByDescending(item => item.Value)
									.ThenBy(item => item.Key)
									.ToDictionary(item => item.Key, item => item.Value);
			junk = junk.OrderBy(item => item.Key)
						.ToDictionary(item => item.Key, item => item.Value);

			foreach (var item in materials)
			{
				Console.WriteLine($"{item.Key}: {item.Value}");
			}
			foreach (var item in junk)
			{
				Console.WriteLine($"{item.Key}: {item.Value}");

			}
		}
	}
}
