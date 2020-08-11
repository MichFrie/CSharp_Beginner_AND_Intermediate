using System;
using System.Text;

namespace Fund_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder();
            str.Append(Console.ReadLine());

            string input;

            while ((input = Console.ReadLine()) != "Travel")
            {
                string[] c = input.Split(':');

                if (c[0] == "Add Stop")
                {
                    int index = int.Parse(c[1]);

                    if (index >= 0 && index < str.Length)
                    {
                        str.Insert(index, c[2]);

                    }
                    Console.WriteLine(str);
                }
                else if (c[0] == "Remove Stop")
                {
                    int start = int.Parse(c[1]);
                    int end = int.Parse(c[2]);

                    if (start >= 0 && end >= 0 && start < str.Length && end < str.Length && end >= start)
                    {
                        str.Remove(start, end - start+1);
                    }
                    Console.WriteLine(str);
                }
                else if (c[0] == "Switch")
                {
                    if (str.ToString().Contains(c[1]))
                    {
                        str.Replace(c[1], c[2]);
                    }
                    Console.WriteLine(str);
                }
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {str}");
        }
    }
}
