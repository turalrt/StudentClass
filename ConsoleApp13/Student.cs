using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Student
    {
        public string FullName;
        public string Course;
        public string Subject;
        public string University;
        public string Email;
        public string PhoneNumber;

        public Student(string fullname, string course, string subject, string university, string email, string phonenumber)
        {
            FullName = fullname;
            Course = course;
            Subject = subject;
            University = university;
            Email = email;
            PhoneNumber = phonenumber;
        }
        public void Info()
        {
            Console.WriteLine($"{FullName} {Course} {Subject} {University} {Email} {PhoneNumber}");
        }

    }
}
