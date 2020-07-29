using System;
using System.Numerics;
using System.Text.RegularExpressions;

namespace Emoji_detector
{
	class Program
	{
		static void Main(string[] args)
		{
			string text = Console.ReadLine();

			if (text.Length > 0)
			{
				BigInteger coolThreshold = 1;

				foreach (var symbol in text)
				{
					if (int.TryParse(symbol.ToString(), out int value))
					{
						coolThreshold *= value;
					}
				}

				MatchCollection emojisValid = Regex.Matches(text, @"::[A-Z]([a-z]){2,}::|\*\*[A-Z]([a-z]){2,}\*\*");

				Console.WriteLine($"Cool threshold: {coolThreshold}");
				Console.WriteLine($"{emojisValid.Count} emojis found in the text. The cool ones are:");

				foreach (var emoji in emojisValid)
				{
					int sum = 0;
					string em = emoji.ToString();
					for (int i = 2; i < em.ToString().Length-2; i++)
					{
						sum += em[i];
					}
					if (sum >= coolThreshold)
					{
						Console.WriteLine(em);
					}
				} 
			}
		}
	}
}
