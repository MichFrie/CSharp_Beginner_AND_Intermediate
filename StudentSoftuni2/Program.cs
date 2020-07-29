using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentSoftuni
{
	public class Student
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
		public string Hometown { get; set; }

		public Student(string f, string l, int a, string h)
		{
			FirstName = f;
			LastName = l;
			Age = a;
			Hometown = h;
		}
	}
	class Program
	{
		static bool Exist(List<Student> s, string f, string l)
		{
			bool exist = false;

			foreach (var student in s)
			{
				if (student.LastName == l && student.FirstName == f)
				{
					exist = true;
				}
			}
			return exist;
		}
		static void Main(string[] args)
		{
			string input;
			List<Student> students = new List<Student>();

			while ((input = Console.ReadLine()) != "end")
			{
				string[] info = input.Split();
				Student newStudent = new Student(info[0], info[1], int.Parse(info[2]), info[3]);
				if (!Exist(students,newStudent.FirstName,newStudent.LastName))
				{
					students.Add(newStudent); 
				}
				else
				{
					Student existingStudent = students.First(currentStudent => currentStudent.FirstName == newStudent.FirstName && currentStudent.LastName == newStudent.LastName);
					existingStudent.FirstName = newStudent.FirstName;
					existingStudent.LastName = newStudent.LastName;
					existingStudent.Age = newStudent.Age;
					existingStudent.Hometown = newStudent.Hometown;
				}
			}

			string prefferedCity = Console.ReadLine();

			List<Student> filteredStudents = students.Where(student => student.Hometown == prefferedCity).ToList();

			foreach (var student in filteredStudents)
			{
				Console.WriteLine($"{student.FirstName} { student.LastName} is { student.Age } years old.");
			}
		}
	}
}