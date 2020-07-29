using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Furniture
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> furn = new List<string>();
			double totalPrice = 0;
			string text;
			while ((text = Console.ReadLine()) != "Purchase")
			{
				Match match = Regex.Match(text, @">>(?<furniture>[A-Za-z]+)<<(?<price>[0-9.]+)!(?<quantity>[0-9]+)");

				if (match.Success)
				{
					furn.Add(match.Groups[1].ToString());
					totalPrice += double.Parse(match.Groups[2].ToString()) * double.Parse(match.Groups[3].ToString()); 
				}
			}
			Console.WriteLine("Bought furniture:");
			foreach (var f in furn)
			{
				Console.WriteLine(f);
			}
			Console.WriteLine($"Total money spend: {totalPrice:f2}");
		}
	}
}
