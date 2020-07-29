using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sttic_class_attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mike's grade is: ");
            Students student1 = new Students("Mike" , int.Parse(Console.ReadLine()));
            Console.WriteLine("Hollard's grade is: ");
            Students student2 = new Students("Hollard" , int.Parse(Console.ReadLine()));
            Console.WriteLine("Annry's grade is: ");
            Students student3 = new Students("Annry" , int.Parse(Console.ReadLine()));
            Console.WriteLine("Alex's grade is: ");
            Students student4 = new Students("Alex" , int.Parse(Console.ReadLine()));

            Students.StudentsGrade(student1.grade);
            Students.StudentsGrade(student2.grade);
            Students.StudentsGrade(student3.grade);
            Students.StudentsGrade(student4.grade);
            
            Console.ReadLine();
        }
    }
}
