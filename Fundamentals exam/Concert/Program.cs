using System;
using System.Collections.Generic;
using System.Linq;

namespace Concert
{
    class Band
    {
        public List<string> members = new List<string>();
        public int time = 0;

        public Band(List<string> m, int t)
        {
            members = m;
            time = t;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Band> concert = new Dictionary<string, Band>();

            string input;
            int totalTime = 0;

            while ((input = Console.ReadLine()) != "start of concert")
            {
                string[] parts = input.Split("; ");

                if (parts[0] == "Add")
                {
                    List<string> currentMembers = parts[2].Split(", ").ToList();
                    if (!concert.ContainsKey(parts[1]))
                    {
                        concert.Add(parts[1],new Band(currentMembers, 0));
                    }
                    else
                    {
                        foreach (var member in currentMembers)
                        {
                            if (!concert[parts[1]].members.Contains(member))
                            {
                                concert[parts[1]].members.Add(member);
                            }
                        }
                    }
                }
                else
                {
                    if (!concert.ContainsKey(parts[1]))
                    {
                        concert.Add(parts[1], new Band(new List<string>(), 0));
                        concert[parts[1]].time = int.Parse(parts[2]);
                    }
                    else
                    {
                        concert[parts[1]].time += int.Parse(parts[2]);
                    }
                    totalTime += int.Parse(parts[2]);
                }
            }
            
            string endBand = Console.ReadLine();

            concert = concert.OrderByDescending(b => b.Value.time)
                             .ThenBy(b => b.Key)
                             .ToDictionary(k => k.Key, v => v.Value);

            Console.WriteLine($"Total time: {totalTime}");

            foreach (var band in concert)
            {
                Console.WriteLine($"{ band.Key} -> { band.Value.time}");
            }


            Console.WriteLine(endBand);

            foreach (var member in concert[endBand].members)
            {
                Console.WriteLine($"=> { member}");
            }
        }
    }
}
