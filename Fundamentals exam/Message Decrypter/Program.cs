using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Message_Decrypter
{
    class Program
    {
        private static string decrypt(List<int> nums)
        {
            StringBuilder word = new StringBuilder();
            foreach (var num in nums)
            {
                word.Append((char)num);
            }
            return word.ToString();
        }
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string text = Console.ReadLine();
                Match match = Regex.Match(text, @"^(\%|\$)(?<tag>[A-Z][a-z]{2,})(?:\1):\s\[(?<num1>[0-9]+)\]\|\[(?<num2>[0-9]+)\]\|\[(?<num3>[0-9]+)\]\|$");
                if (match.Success)
                {
                    string decrypted = decrypt(new List<int> { int.Parse(match.Groups["num1"].Value), int.Parse(match.Groups["num2"].Value), int.Parse(match.Groups["num3"].Value) });
                    Console.WriteLine($"{match.Groups["tag"]}: {decrypted}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
