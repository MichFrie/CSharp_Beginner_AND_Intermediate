using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Song_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                Match match = Regex.Match(input.ToString(), @"^(?<artist>[A-Z][a-z\s']+)\:(?<song>[A-Z\s]+)$");
                if (match.Success)
                {
                    StringBuilder encrypted = new StringBuilder();
                    string song = match.Value;
                    int songLength = match.Groups["artist"].Value.Length;
                    for (int i = 0; i < song.Length; i++)
                    {
                        if (song[i] != ' ' && song[i] != '\'')
                        {
                            if (song[i] != ':')
                            {
                                if ((song[i] + songLength > 64 && song[i] + songLength < 91 && song[i] < 91) || (song[i] + songLength > 96 && song[i] + songLength < 123 && song[i] > 96))
                                {
                                    encrypted.Append((char)(song[i] + songLength));

                                }
                                else if (song[i] < 91)
                                {
                                    encrypted.Append((char)((song[i] + songLength) % 90 + 64));

                                }
                                else if (song[i] > 96)
                                {
                                    encrypted.Append((char)((song[i] + songLength) % 122 + 96));

                                }
                            }
                            else
                            {
                                encrypted.Append("@");
                            }
                        }
                        else if (song[i] == ' ')
                        {
                            encrypted.Append(' ');
                        }
                        else
                        {
                            encrypted.Append("'");
                        }
                    }
                    Console.WriteLine($"Successful encryption: {encrypted}");
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}
