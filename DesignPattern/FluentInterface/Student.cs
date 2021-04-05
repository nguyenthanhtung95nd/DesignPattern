using System;
using System.Collections.Generic;
using System.Linq;

namespace CreationalDesignPattern.FluentInterface
{
    public class Student
    {
        public Student()
        {
        }

        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Department { get; set; }
        public string Address { get; set; }
        public List<string> ListCourses { get; }

        public Student BuildListCourse(params string[] listCourse)
        {
            if (listCourse.Any())
            {
                ListCourses.AddRange(listCourse);
            }

            return this;
        }

        public Student Born(string dateOfBirth)
        {
            this.DateOfBirth = Convert.ToDateTime(dateOfBirth);
            return this;
        }

        public Student WorkingOn(string department)
        {
            this.Department = department;
            return this;
        }

        public Student StaysAt(string address)
        {
            this.Address = address;
            return this;
        }
    }
}