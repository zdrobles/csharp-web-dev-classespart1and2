using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    internal class Course
    {
        public List<Student> EnrolledStudents { get; set; }
        public string Subject { get; set; }
        public int Credits { get; set; }
        public Teacher Instructor { get; set; }
        public int CourseId { get; set; }
        private static int nextId = 101;

        public Course(List<Student> students, string subject, int credits, Teacher instructor)
        {
            EnrolledStudents = students;
            Subject = subject;
            Credits = credits;
            Instructor = instructor;
            CourseId = nextId++;
        }
    }
}
