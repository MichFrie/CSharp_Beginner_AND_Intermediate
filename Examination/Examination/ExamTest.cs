using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination
{
    class ExamTest
    {
        public double Grade;
        public static double GradeCount;
        public static double AverageGrade;
       
        public ExamTest(double aGrade)
        {   
            Grade = aGrade;
            GradeCount++;
            Average(Program.GradeSum / GradeCount);
        }

        static void Average(double aAverageGrade)
        { 
            AverageGrade = aAverageGrade;         
        }
    }
}
