using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;

namespace Softuni_courses
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
			string input;

			while ((input = Console.ReadLine()) != "end")
			{
				string[] comm = input.Split(" : ");

				if (courses.ContainsKey(comm[0]))
					courses[comm[0]].Add(comm[1]);
				else
					courses.Add(comm[0], new List<string> { comm[1] });
			}
			courses = courses.OrderByDescending(course => course.Value.Count)
							.ToDictionary(course => course.Key, course => course.Value);

			foreach (var course in courses)
			{
				Console.WriteLine($"{course.Key}: {course.Value.Count}");
				List<string> students = course.Value.OrderBy(name => name).ToList();

				foreach (var student in students)
				{
					Console.WriteLine($"-- {student}");
				}
			}
		}
	}
}
