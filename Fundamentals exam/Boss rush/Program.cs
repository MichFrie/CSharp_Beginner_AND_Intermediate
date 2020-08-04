using System;
using System.Text.RegularExpressions;

namespace Boss_rush
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string boss = Console.ReadLine();
                string pattern = @"\|(?<name>[A-Z]{4,})\|\:\#(?<title>[A-Za-z]+\s[A-Za-z]+)\#";
                if (Regex.IsMatch(boss, pattern))
                {
                    var match = Regex.Match(boss, pattern);
                    
                    Console.WriteLine($"{match.Groups["name"]}, The {match.Groups["title"]}");
                    Console.WriteLine($">> Strength: { match.Groups["name"].Value.Length}");
                    Console.WriteLine($">> Armour: { match.Groups["title"].Value.Length}");
                }
                else
                {
                    Console.WriteLine("Access denied!");
                }
            }

        }
    }
}
