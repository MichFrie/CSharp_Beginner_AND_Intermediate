using System;
using System.Collections.Specialized;
using System.Text;

namespace Password_reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = Console.ReadLine();

            string input;

            while ((input = Console.ReadLine()) != "Done")
            {
                string[] c = input.Split(" ");

                if (c[0] == "TakeOdd")
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 1; i < result.Length; i += 2)
                    {
                        sb.Append(result[i]);
                    }
                    result = sb.ToString();
                    Console.WriteLine(result);
                }
                else if(c[0] == "Cut")
                {
                    int startIndex = int.Parse(c[1]);
                    int lenght = int.Parse(c[2]);
                    int test = startIndex + lenght;

                    if (test <= result.Length)
                    {
                        string substr = result.Substring(startIndex, lenght);
                        int index = result.IndexOf(substr);
                        result = result.Remove(index, substr.Length);
                        Console.WriteLine(result);
                    }

                }
                else if (c[0] == "Substitute")
                {
                    if (result.Contains(c[1]))
                    {
                        result = result.Replace(c[1],c[2]);
                        Console.WriteLine(result);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
            }
            Console.WriteLine($"Your password is: {result}");
        }
    }
}
