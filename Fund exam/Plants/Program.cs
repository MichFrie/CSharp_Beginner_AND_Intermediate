using System;
using System.Collections.Generic;
using System.Linq;

namespace Plants
{
    class Plant
    {
        public double rarity { get; set; }
        public List<int> rates { get; set; }
        public double average { get; set; }

        public Plant(double r)
        {
            rarity = r;
            rates = new List<int>();
            average = 0.0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Plant> records = new Dictionary<string, Plant>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] com = Console.ReadLine().Split("<->");

                if (com.Length == 2)
                {
                    if (records.ContainsKey(com[0]))
                    {
                        records[com[0]].rarity = double.Parse(com[1]);
                    }
                    else
                    {
                        records.Add(com[0], new Plant(double.Parse(com[1])));
                    }
                }
            }

            if (records.Count > 0)
            {
                string input;

                while ((input = Console.ReadLine()) != "Exhibition")
                {
                    string[] c = input.Split(": ");
                    if (c.Length == 2)
                    {
                        string[] info = c[1].Split(" - ");

                        if (c[0] == "Rate" && info.Length == 2)
                        {
                            if (records.ContainsKey(info[0]))
                            {
                                records[info[0]].rates.Add(int.Parse(info[1]));
                            }
                            else
                            {
                                Console.WriteLine("error");
                            }

                        }
                        else if (c[0] == "Update" && info.Length == 2)
                        {
                            if (records.ContainsKey(info[0]))
                            {
                                records[info[0]].rarity = double.Parse(info[1]);
                            }
                            else
                            {
                                Console.WriteLine("error");

                            }
                        }
                        else if (c[0] == "Reset" && info.Length == 1)
                        {
                            if (records.ContainsKey(info[0]))
                            {
                                records[info[0]].rates.Clear();
                            }
                            else
                            {
                                Console.WriteLine("error");

                            }
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
            }

            foreach (var p in records)
            {
                if (p.Value.rates.Count > 0)
                {
                    records[p.Key].average = p.Value.rates.Average();
                }
                else
                {
                    records[p.Key].average = 0.0;
                }
            }

            records = records.OrderByDescending(p => p.Value.rarity)
                             .ThenByDescending(p => p.Value.average)
                             .ToDictionary(k => k.Key, v => v.Value);

            Console.WriteLine("Plants for the exhibition:");
            foreach (var plant in records)
            {
                Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value.rarity}; Rating: {plant.Value.average:f2}");
            }
        }
    }
}
