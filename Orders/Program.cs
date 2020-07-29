using System;
using System.Collections.Generic;

namespace Orders
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, List<double>> products = new Dictionary<string,List<double>>();

			string input;

			while ((input = Console.ReadLine()) != "buy")
			{
				string[] c = input.Split();
				string name = c[0];
				double price = double.Parse(c[1]);
				int quantity = int.Parse(c[2]);

				if (products.ContainsKey(name))
				{
					if (products[name][0] != price)
					{
						products[name][0] = price;
					}
					products[name][1] += quantity;
				}
				else
				{
					products.Add(name, new List<double> { price, quantity});
				}

			}
			foreach (var item in products)
			{
				double mul = item.Value[0] * item.Value[1];
				Console.WriteLine($"{ item.Key} -> { mul:f2}");
			}
		}
	}
}
