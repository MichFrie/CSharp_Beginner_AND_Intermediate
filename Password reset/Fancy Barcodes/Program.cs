using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                if (Regex.IsMatch(input, @"@#+[A-Z][A-Za-z0-9]{4,}[A-Z]@#+"))
                {
                    StringBuilder digits = new StringBuilder();

                    for (int j = 2; j < input.Length-2; j++)
                    {
                        if (char.IsDigit(input[j]))
                        {
                            digits.Append(input[j]);
                        }
                    }

                    if (digits.Length == 0)
                    {
                        Console.WriteLine($"Product group: 00");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {digits}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
