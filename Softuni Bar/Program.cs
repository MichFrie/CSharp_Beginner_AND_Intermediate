using System;
using System.Text.RegularExpressions;

namespace Softuni_Bar
{
	class Program
	{
		static void Main(string[] args)
		{
			decimal totalPrice = 0;

			string input;

			while ((input = Console.ReadLine()) != "end of shift")
			{
				Match match = Regex.Match(input, @"%(?<name>[A-Z][a-z]+)%[^$|%.]*<(?<product>[A-Za-z]+)>[^$|%.]*\|(?<quantity>[0-9]+)\|[^0-9$|%.]*(?<price>[0-9]+.?[0-9]+)\$");

				if (match.Success)
				{
					Console.WriteLine($"{match.Groups["name"]}: {match.Groups["product"]} - {decimal.Parse(match.Groups["price"].ToString())*int.Parse(match.Groups["quantity"].ToString()):f2}");
					totalPrice += decimal.Parse(match.Groups["price"].ToString()) * int.Parse(match.Groups["quantity"].ToString());
				}
			}

			Console.WriteLine($"Total income: {totalPrice:f2}");
		}
	}
}
