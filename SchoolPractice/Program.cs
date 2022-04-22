using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student zach = new Student("Zach", 1, 4.0);
            Student josh = new Student("Josh", 1, 4.0);

            Teacher colin = new Teacher("Colin", "Brock", "C#", 1);

            List<Student> studentList = new List<Student>
            {
                zach,
                josh,
            };

            Course LaunchCode = new Course(studentList, "C#", 1, colin);

            foreach (Student student in studentList)
            {
                Console.WriteLine($"{student.Name}: {student.StudentId}");
            }
            Console.WriteLine($"Teacher: {colin.FirstName} {colin.LastName}");
            Console.WriteLine($"Course: {LaunchCode.Subject} {LaunchCode.CourseId} {LaunchCode.Instructor.LastName} {LaunchCode.Credits}");
        }
    }
}
