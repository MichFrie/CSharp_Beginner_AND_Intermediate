using System;

namespace Examination
{
    class Program
    {
        public static double GradeSum;
        public static int a = 0;
        public static int b = 0;

        static void Main(string[] args)
        {
            try
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Hello! Today we have examination!");
                do
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Green;
                    double grade1 = 0;
                    double grade2 = 0;
                    double grade3 = 0;
                    double grade4 = 0;
                    GradeSum = 0;
                    ExamTest.GradeCount = 0;
                    ExamTest.AverageGrade = 0;
                    if (b <= 0)
                    {
                        Console.WriteLine("Grades:");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("New grades:");
                    }
                    Console.WriteLine("First grade is:");
                    grade1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Second grade is:");
                    grade2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Third grade is:");
                    grade3 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Forth grade is:");
                    grade4 = double.Parse(Console.ReadLine());
                    if (grade1 > 1 && grade1 < 7 && grade2 > 1 && grade2 < 7 && grade3 > 1 && grade3 < 7 && grade4 > 1 && grade4 < 7)
                    {
                        GradeSum = grade1 + grade2 + grade3 + grade4;
                        ExamTest test1 = new ExamTest(grade1);
                        ExamTest test2 = new ExamTest(grade2);
                        ExamTest test3 = new ExamTest(grade3);
                        ExamTest test4 = new ExamTest(grade4);
                        Console.WriteLine("The average grade is: {0:0.00}", ExamTest.AverageGrade);
                        Console.ResetColor();
                        b++;
                    }
                    else
                    {
                        a = 1;
                        Console.WriteLine("There aren't this type of grades!!!");
                    }
                }
                while( a == 0);
                Console.ReadKey();

            }
            catch(Exception)
            {
                Console.WriteLine("Grates can be only integers");
            }
                
        }
    }
}
