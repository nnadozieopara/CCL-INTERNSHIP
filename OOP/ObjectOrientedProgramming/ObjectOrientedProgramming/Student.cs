using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    public class Student : Person
    {
        public Student()
        {
        }

        public Student(int gradeLevel, string sportsHouse):this()
        {
            GradeLevel = gradeLevel;
            SportsHouse = sportsHouse;
        }

        public double PaySchoolFees(double amount)
        {
            return amount;
        }

        public bool HasPaidSchoolFees(double amount)
        {
            if (amount <= 0) return false;
            return true;
        }

        public override void Sit()
        {
            Console.WriteLine("I am sitting in the class room"); 
        }

        public override void Walk()
        {
            Console.WriteLine("I am walking to my class room");
        }
        public int GradeLevel { get; set; }
        public string SportsHouse { get; set; }
    }
}
