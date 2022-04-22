using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        private static int nextId = 1;
        public Student(string name, int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = nextId++;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }
    }
}
