using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace destination
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, @"(\=|\/)(?<word>[A-Z][A-Za-z]{2,})(\1)");
            int points = 0;
            List<string> words = new List<string>();

            for (int i = 0; i < matches.Count; i++)
            {
                points += matches[i].Groups["word"].Value.Length;
                words.Add(matches[i].Groups["word"].Value);
            }

            Console.WriteLine($"Destinations: {string.Join(", ", words)}");
            Console.WriteLine($"Travel Points: {points}");
        }
    }
}
