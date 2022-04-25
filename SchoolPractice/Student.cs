using System;
namespace SchoolPractice
{
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentId,
            int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
        : this(name, studentId, 0, 0) { }

        public Student(string name)
        : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        // TODO: Complete the AddGrade method.gpa = (total quality score) / (total number of credits)
        public void AddGrade(int courseCredits, double grade)
        {
            // Update the appropriate properties: NumberOfCredits, Gpa
            double totalQualityScore = Gpa * NumberOfCredits + grade * courseCredits;

            NumberOfCredits += courseCredits;
            Gpa = totalQualityScore / NumberOfCredits;
        }

        //TODO: Complete the GetGradeLevel method here: 
        public string GetGradeLevel(int credits)
        {
            string gradeLevel = "";
            // Determine the grade level of the student based on NumberOfCredits
            if (credits >= 90)
            {
                gradeLevel = "Senior";
            }
            else if (credits >= 60)
            {
                gradeLevel = "Junior";
            }
            else if (credits >= 30)
            {
                gradeLevel = "Sophomore";
            }
            else if (credits >= 0)
            {
                gradeLevel = "Freshman";
            }
            else { gradeLevel = "Not enrolled"; }

            return gradeLevel;
        }


        // TODO: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather
        //  than just the class fields.
        public override string ToString()
        {
            return $"\nName: {Name}\nID: {StudentId}\nYear: {GetGradeLevel(NumberOfCredits)}\nTotal Credits: {NumberOfCredits}\nGPA: {Math.Round(Gpa * 100) / 100}\n";
        }

        // TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
        //  Student objects equal.
        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   StudentId == student.StudentId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(StudentId);
        }
    }
}
