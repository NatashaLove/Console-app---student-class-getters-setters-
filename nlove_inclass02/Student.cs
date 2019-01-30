using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nlove_inclass02
{
    public class Student : Person
    {
        private double _gpa;
        private string _level;

        // Student constructor - calls the base constructor (must have the same parameters!)
        public Student(string id, string firstName, string midInit, string lastName, int age) : base(id, firstName, midInit, lastName, age)
        {
            GPA = 4.0;
            Level = "Freshman";
        }

        public double GPA { get { return _gpa; } set { _gpa = value; } }
        public string Level { get { return _level; } set { _level = value; } }

        public override string DisplayInformation()
        {
            return String.Format("Student ID {0}\n" +
                "Name: {1} {2} {3}\n" +
                "Level: {4}\n" +
                "Age: {5}\n" +
                "GPA: {6}",
                //insert variables- properties - from the constructor of- Person abstract class- where we described them
                ID, FirstName, MidInit, LastName, Level, Age, GPA);
        }
    }
}
