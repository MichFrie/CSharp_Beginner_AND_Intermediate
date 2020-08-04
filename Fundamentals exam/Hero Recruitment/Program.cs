using System;
using System.Collections.Generic;
using System.Linq;

namespace Hero_Recruitment
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            Dictionary<string, List<string>> heroes = new Dictionary<string, List<string>>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] c = input.Split();

                switch (c[0])
                {
                    case "Enroll":
                        if (heroes.ContainsKey(c[1]))
                        {
                            Console.WriteLine($"{c[1]} is already enrolled.");
                        }
                        else
                        {
                            heroes.Add(c[1], new List<string>());
                        }
                        break;
                    case "Learn":
                        if (heroes.ContainsKey(c[1]))
                        {
                            if (heroes[c[1]].Contains(c[2]))
                            {
                                Console.WriteLine($"{c[1]} has already learnt {c[2]}.");
                            }
                            else
                            {
                                heroes[c[1]].Add(c[2]);
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{c[1]} doesn't exist.");
                        }
                        break;
                    case "Unlearn":
                        if (heroes.ContainsKey(c[1]))
                        {
                            if (!heroes[c[1]].Contains(c[2]))
                            {
                                Console.WriteLine($"{c[1]} doesn't know {c[2]}.");
                            }
                            else
                            {
                                heroes[c[1]].Remove(c[2]);
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{c[1]} doesn't exist.");
                        }
                        break;
                    default:
                        break;
                }
            }

            heroes = heroes.OrderByDescending(h => h.Value.Count).ThenBy(h => h.Key).ToDictionary(k => k.Key, v => v.Value);
            Console.WriteLine($"Heroes:");
            foreach (var hero in heroes)
            {
                Console.WriteLine($"== {hero.Key}: {string.Join(", ", hero.Value)}");
            }
        }
    }
}
