using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace regex_softuni
{
	class Program
	{
		static void Main(string[] args)
		{

			string text = Console.ReadLine();

			MatchCollection matches = Regex.Matches(text, @"\b(?<day>\d{2})(.|\/|-)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b");

			foreach (Match match in matches)
			{
				Console.WriteLine($"Day: {match.Groups[2]}, Month: {match.Groups[3]}, Year: {match.Groups[4]}");
			}

		}
	}
}
