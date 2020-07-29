using System;
using System.Collections.Generic;
using System.Linq;

namespace students_academy
{
	class Program
	{ 

		static double average(List<double> grades)
		{
			double av = 0;
			for (int i = 0; i < grades.Count; i++)
			{
				av += grades[i];

			}
			return av / grades.Count;
		}
		static void Main(string[] args)
		{
			Dictionary<string, List<double>> class1 = new Dictionary<string, List<double>>();

			int count = int.Parse(Console.ReadLine());

			for (int i = 0; i < count; i++)
			{
				string name = Console.ReadLine();
				double grade = double.Parse(Console.ReadLine());

				if (class1.ContainsKey(name))
				{
					class1[name].Add(grade);
				}
				else
				{
					class1.Add(name, new List<double> { grade });
				}
			}

			Dictionary<string, double> goodStudents = new Dictionary<string, double>();

			foreach (var student in class1)
			{
				double average1 = average(student.Value);
				if (average1 >= 4.50)
				{
					goodStudents.Add(student.Key, average1);
				}
			}
			goodStudents = goodStudents.OrderByDescending(student => student.Value)
									.ToDictionary(s => s.Key, s => s.Value);

			foreach (var s in goodStudents)
			{
				Console.WriteLine($"{s.Key} -> {s.Value:f2}");
			}
		}
	}
}
