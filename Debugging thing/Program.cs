using System;
using System.Collections.Generic;
namespace Debugging_thing
{
	class Program
	{
		static List<Tuple<int, string, double>> listOfProducts = new List<Tuple<int, string, double>>();

		static void GetProducts()
		{
			while (true)
			{
				string output = Console.ReadLine();

				if (output != "Quit")
				{
					string product = output.Split("-$")[0];
					double price = Math.Round(double.Parse(output.Split("-$")[1]), 2);

					listOfProducts.Add(new Tuple<int, string, double>(listOfProducts.Count + 1, product, price)); 
				}
				else
				{
					break;
				}
			}
		}

		static double CalculateThePrice()
		{
			double totalPrice = 0;

			foreach (var item in listOfProducts)
			{
				totalPrice += item.Item3;
			}

			return totalPrice;
		}

		static void Main(string[] args)
		{
			GetProducts();
			double totalPriceOfAllProducts = CalculateThePrice();

			Console.WriteLine();

			Console.WriteLine($"Products ammount: {listOfProducts.Count}");

			foreach (var item in listOfProducts)
			{
				Console.WriteLine($"{item.Item1}. { item.Item2.ToString().Substring(0,1).ToUpper() }{ item.Item2.ToString().Substring(1) } <---> ${item.Item3:f2}");
			}

			Console.WriteLine();
			if (listOfProducts.Count != 0)
			{
				Console.WriteLine($"Total: ${totalPriceOfAllProducts:f2}"); 
			}
			else
			{
				Console.WriteLine("List of products is empty!");
			}

		}
	}
}
