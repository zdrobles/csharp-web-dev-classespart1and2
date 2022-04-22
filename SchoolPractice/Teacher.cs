using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    internal class Teacher
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Subject { get; set; }
        public int YearsTeaching { get; set; }

        public Teacher(string firstName, string lastName, string subject, int yearsTeaching)
        {
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
            YearsTeaching = yearsTeaching;
        }
    }
}
