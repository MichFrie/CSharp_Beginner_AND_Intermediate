using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamResultCalc
{
	class Program
	{
		static void Main(string[] args)
		{
			int StudentsCount = int.Parse(Console.ReadLine());
			double Students = StudentsCount;

			int TopStudents = 0;
			int SecondStudents = 0;
			int ThirdStudents = 0;
			int FailedStudents = 0;


			double TopInPercent = 0;
			double SecondInPercent = 0;
			double ThirdInPercent = 0;
			double FailedInPercent = 0;

			double SumResults = 0;
			double AverageResult = 0;

			double ResultPerStudent = 0;

			if (StudentsCount >= 1 && StudentsCount <= 1000)
			{
				while (StudentsCount > 0)
				{
					
					ResultPerStudent = double.Parse(Console.ReadLine());

					if (ResultPerStudent >= 5 && ResultPerStudent <= 6)
					{
						TopStudents = TopStudents + 1;
					}
					else if (ResultPerStudent >= 4 && ResultPerStudent < 5)
					{
						SecondStudents = SecondStudents + 1;
					}
					else if (ResultPerStudent >= 3 && ResultPerStudent < 4)
					{
						ThirdStudents = ThirdStudents + 1;
					}
					else if (ResultPerStudent < 3 && ResultPerStudent >= 2)
					{
						FailedStudents = FailedStudents + 1;
						
					}

					SumResults += ResultPerStudent;
					StudentsCount--;
					ResultPerStudent = 0;
				}
			}

			TopInPercent = (TopStudents / Students) * 100;
			SecondInPercent = (SecondStudents / Students) * 100;
			ThirdInPercent = (ThirdStudents / Students) * 100;
			FailedInPercent = (FailedStudents / Students) * 100;

			Console.WriteLine("Top students: {0:0.00}%", TopInPercent);
			Console.WriteLine("Between 4.00 and 4.99: {0:0.00}%", SecondInPercent);
			Console.WriteLine("Between 3.00 and 3.99: {0:0.00}%", ThirdInPercent);
			Console.WriteLine("Fail: {0:0.00}%", FailedInPercent);
			
			AverageResult = SumResults / Students;
			Console.WriteLine("Average: {0:0.00}", AverageResult);
		}
	}
}
