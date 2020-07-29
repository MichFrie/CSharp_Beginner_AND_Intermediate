using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination
{
    class Student
    {
        public static int StudentCount = 0;
        public static int SumGrade = 0;
        public string StudentName;
        public string StudentClass;
        public int Grade;

        public Student(string aStudentName , string aStudentClass , int aGrade)
        {
            StudentName = aStudentName;
            StudentClass = aStudentClass;
            Grade = aGrade;
            StudentCount++;
        }
        
    }
}
