using System;
using System.Collections.Generic;
using System.Linq;

namespace Manage_messeges
{
    class Person
    {
        public int sended;
        public int received;

        public Person(int s, int r)
        {
            sended = s;
            received = r;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Person> records = new Dictionary<string, Person>();

            int capacity = int.Parse(Console.ReadLine());

            string input;

            while ((input = Console.ReadLine()) != "Statistics")
            {
                string[] command = input.Split("=");

                switch (command[0])
                {
                    case "Add":
                        if (!records.ContainsKey(command[1]))
                        {
                            records.Add( command[1], new Person(int.Parse(command[2]), int.Parse(command[3])) );
                        }
                        break;
                    case "Message":
                        if (records.ContainsKey(command[1]) && records.ContainsKey(command[2]))
                        {
                            records[command[1]].sended++;
                            records[command[2]].received++;

                            if (records[command[1]].sended + records[command[1]].received >= capacity)
                            {
                                records.Remove(command[1]);
                                Console.WriteLine($"{command[1]} reached the capacity!");
                            }

                            if (records[command[2]].sended + records[command[2]].received >= capacity)
                            {
                                records.Remove(command[2]);
                                Console.WriteLine($"{command[2]} reached the capacity!");
                            }
                                
                        }

                        

                        break;

                    case "Empty":
                        if (command[1] == "All")
                        {
                            records.Clear();
                        }
                        else
                        {
                            records.Remove(command[1]);
                        }
                        break;
                    default:
                        break;
                }
            }
            records = records.OrderByDescending(r => r.Value.received)
                             .ThenBy(r => r.Key)
                             .ToDictionary(k => k.Key, v => v.Value);

            Console.WriteLine($"Users count: {records.Count}");
            foreach (var record in records)
            {
                Console.WriteLine($"{record.Key} - {record.Value.sended + record.Value.received}");
            }
        }
    }
}
