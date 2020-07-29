using System;
using System.Collections.Generic;
using System.Text;

namespace String
{
	public class StringSummarizer
	{
		public static string SummarizeText(string text, int maxLength = 20)
		{
			if (text.Length < maxLength)
			{
				return text;
			}
			else
			{
				string[] words = text.Split();
				var summaryWords = new List<string>();

				int ammountOfCharacter = 0;

				foreach (string word in words)
				{
					summaryWords.Add(word);

					ammountOfCharacter += word.Length + 1;
					if (ammountOfCharacter >= maxLength)
					{
						break;
					}
				}

				var summaryText = string.Join(" ", summaryWords) + "...";
				return summaryText;
			}
		}
	}
}
