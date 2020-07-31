using System;
using System.Globalization;
using System.Text;

namespace Nikulden_s_charity
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder input = new StringBuilder();
            input.Append(Console.ReadLine());

            string inp;

            while ((inp  = Console.ReadLine()) != "Finish")
            {
                string[] command = inp.Split();

                if (command[0] == "Replace")
                {
                    input.Replace(command[1], command[2]);
                    Console.WriteLine(input);
                }
                else if (command[0] == "Cut")
                {
                    int start = int.Parse(command[1]);
                    int end = int.Parse(command[2]);
                    if (start > -1 && end < input.Length)
                    {
                        input.Remove(start, end - start+1);
                        Console.WriteLine(input);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                }
                else if (command[0] == "Make")
                {
                    if (command[1] == "Upper")
                    {
                        for (int i = 0; i < input.Length; i++)
                        {
                            input[i] = char.Parse(input[i].ToString().ToUpper());
                        }
                    }
                    else
                    {
                        for (int i = 0; i < input.Length; i++)
                        {
                            input[i] = char.Parse(input[i].ToString().ToLower());
                        }
                    }
                    Console.WriteLine(input);
                }
                else if (command[0] == "Check")
                {
                    if (input.ToString().Contains(command[1]))
                    {
                        Console.WriteLine($"Message contains {command[1]}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {command[1]}");
                    }
                }
                else
                {
                    int start = int.Parse(command[1]);
                    int end = int.Parse(command[2]);

                    if (start > -1 && end < input.Length)
                    {
                        StringBuilder cut = new StringBuilder();

                        for (int i = start; i <= end; i++)
                        {
                            cut.Append(input[i]);
                        }

                        int sum = 0;

                        for (int i = 0; i < cut.Length; i++)
                        {
                            sum += cut[i];
                        }
                        Console.WriteLine(sum);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                }
            }
        }
    }
}
