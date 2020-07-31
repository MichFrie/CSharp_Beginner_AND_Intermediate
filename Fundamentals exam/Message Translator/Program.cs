using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Message_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string rawMessage = Console.ReadLine();

                if (Regex.IsMatch(rawMessage, @"!(?<c>[A-Z][a-z]{2,})!:\[(?<m>[A-Za-z]{8,})\]"))
                {
                    StringBuilder code = new StringBuilder();
                    Match match = Regex.Match(rawMessage, @"!(?<c>[A-Z][a-z]{2,})!:\[(?<m>[A-Za-z]{8,})\]");

                    string message = match.Groups["m"].Value;
                    for (int j = 0; j < message.Length; j++)
                    {
                        code.Append((int)message[j] + " ");
                    }
                    Console.WriteLine($"{match.Groups["c"].Value}: {code.ToString().TrimEnd()}");
                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }
            }
        }
    }
}
