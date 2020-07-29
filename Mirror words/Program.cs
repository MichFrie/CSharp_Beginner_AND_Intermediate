using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Mirror_words
{
	
	class Program
	{
		static void Main(string[] args)
		{
			string inp = Console.ReadLine();

			string pattern1 = @"(@(?<first>[A-Za-z]{3,})@@(?<second>[A-Za-z]{3,})@)|#(?<first>[A-Za-z]{3,})##(?<second>[A-Za-z]{3,})#";

			List<string> mirrors = new List<string>();

			MatchCollection matches = Regex.Matches(inp, pattern1);
			

			if (matches.Count > 0)
			{
				Console.WriteLine($"{matches.Count} word pairs found!");

				foreach (Match match in matches)
				{
					char[] c = match.Groups[3].Value.ToCharArray();
					Array.Reverse(c);

					if (match.Groups[2].Value == new string(c))
					{
						mirrors.Add($"{match.Groups[2]} <=> {match.Groups[3]}");
					}
				}
			}
			else
			{
				Console.WriteLine("No word pairs found!");
			}

			if (mirrors.Count > 0)
			{
				Console.WriteLine("The mirror words are:");
				Console.WriteLine(string.Join(", ", mirrors));
			}
			else
			{
				Console.WriteLine("No mirror words!");
			}
		}
	}
}
