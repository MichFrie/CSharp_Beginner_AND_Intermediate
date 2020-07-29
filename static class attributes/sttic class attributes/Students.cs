using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sttic_class_attributes
{
    class Students
    {
        public string StudentName;
        public int grade;
        public static int StudentCount;

        public Students(string aStudentName, int aGrade)
        {
            StudentName = aStudentName;
            grade = aGrade;
            StudentCount++;
        }
        
        public static void  StudentsGrade(int Grade)
        {
            Console.WriteLine("Grade: " + Grade);
        }
    }
}
