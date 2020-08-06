using System;
using System.Text;

namespace String_Manipulator__1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] commands = input.Split();

                switch (commands[0])
                {
                    case "Translate":

                        text = text.Replace(commands[1],commands[2]);
                        Console.WriteLine(text);
                        break;
                    case "Includes":

                        if (text.Contains(commands[1]))
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }

                        break;
                    case "Start":

                        StringBuilder cut = new StringBuilder();

                        for (int i = 0; i < commands[1].Length; i++)
                        {
                            cut.Append(text[i]);
                        }

                        if (cut.ToString() == commands[1])
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }

                        break;
                    case "Lowercase":

                        text = text.ToLower();
                        Console.WriteLine(text);

                        break;
                    case "FindIndex":
                        Console.WriteLine(text.LastIndexOf(commands[1]));

                        break;
                    case "Remove":
                        text = text.Remove(int.Parse(commands[1]), int.Parse(commands[2]));
                        Console.WriteLine(text);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
