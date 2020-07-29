using System;
using System.Text.RegularExpressions;

namespace Email_Extract
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            MatchCollection matches = Regex.Matches(input, @"(?<user>(^|\s)[A-Za-z0-9]+[.\-_]?[A-Za-z0-9]+)@(?<host>(?:[A-Za-z]+[\-]?[A-Za-z]+)(?:\.[A-Za-z]+){1,})");

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value.ToString().Trim());
            }
        }
    }
}
