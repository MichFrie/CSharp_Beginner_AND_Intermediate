using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Race_Coodinates
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Match match = Regex.Match(Console.ReadLine(), @"([#$%*&])(?<name>[A-Za-z]+)\1\=(?<length>[0-9]+)\!\!(?<encrypted>.+)");

                if (match.Success && int.Parse(match.Groups["length"].Value) == match.Groups["encrypted"].Value.Length)
                {
                    StringBuilder decrypt = new StringBuilder();
                    string code = match.Groups["encrypted"].Value;
                    for (int i = 0; i < code.Length; i++)
                    {
                        decrypt.Append((char)(code[i] + int.Parse(match.Groups["length"].Value)));
                    }
                    Console.WriteLine($"Coordinates found! { match.Groups["name"].Value} -> { decrypt}");
                    break;
                }
                else
                {
                    Console.WriteLine("Nothing found!");
                }
            }
        }
    }
}
