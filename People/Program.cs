using System;
using System.Collections.Generic;
using System.Linq;

namespace People
{
	class Person
	{
		public string Name { get; set; }
		public string ID { get; set; }
		public int Age { get; set; }

		public Person(string n, string id, int a)
		{
			Name = n;
			ID = id;
			Age = a;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			List<Person> people = new List<Person>();
			string i;

			while ((i = Console.ReadLine()) != "End")
			{
				string[] c = i.Split();
				Person p = new Person(c[0], c[1], int.Parse(c[2]));
				people.Add(p);
			}
			people = people.OrderBy(p => p.Age).ToList();

			foreach (var p in people)
			{
				Console.WriteLine($"{p.Name} with ID: {p.ID} is {p.Age} years old.");
			}
		}
	}
}
