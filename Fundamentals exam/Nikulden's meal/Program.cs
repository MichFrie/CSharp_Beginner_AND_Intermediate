using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Nikulden_s_meal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> likes = new Dictionary<string, List<string>>();
            int dislikes = 0;

            string input;

            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] command = input.Split("-");

                if (command[0] == "Like")
                {
                    if (!likes.ContainsKey(command[1]))
                    {
                        likes.Add(command[1], new List<string>() { command[2] });
                    }
                    else
                    {
                        if (!likes[command[1]].Contains(command[2]))
                        {
                            likes[command[1]].Add(command[2]);
                        }
                    }
                }
                else
                {
                    if (!likes.ContainsKey(command[1]))
                    {
                        Console.WriteLine($"{command[1]} is not at the party.");
                    }
                    else if (!likes[command[1]].Contains(command[2]))
                    {
                        Console.WriteLine($"{command[1]} doesn't have the {command[2]} in his/her collection.");
                    }
                    else
                    {
                        likes[command[1]].Remove(command[2]);
                        dislikes++;
                        Console.WriteLine($"{command[1]} doesn't like the {command[2]}.");
                    }
                }
            }

            likes = likes.OrderByDescending(person => person.Value.Count)
                         .ThenBy(person => person.Key)
                         .ToDictionary(k => k.Key, v => v.Value);

            foreach (var item in likes)
            {
                Console.WriteLine($"{item.Key}: {string.Join(", ", item.Value)}");
            }
            Console.WriteLine($"Unliked meals: {dislikes}");
        }
    }
}
