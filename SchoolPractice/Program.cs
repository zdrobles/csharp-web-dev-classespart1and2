using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Test your exercise solutions with print statements here.
            Student testStudent = new Student("Billy");
            Student testStudent2 = new Student("William");

            List<Student> classList = new List<Student>
            {
                testStudent, testStudent2
            };
            Teacher colin = new Teacher("Colin", "Brock", "Computer Science", 1);
            Course csharp = new Course("C#", colin, classList);

            testStudent.AddGrade(3, 4.0);
            testStudent.AddGrade(4, 3.0);
            Console.WriteLine(testStudent);
            //Console.WriteLine(testStudent.Equals(testStudent2));
            Console.WriteLine(csharp);
        }
    }
}
