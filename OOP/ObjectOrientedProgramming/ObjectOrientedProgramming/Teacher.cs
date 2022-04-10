using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    public class Teacher : Person
    {
        public Teacher()
        {
           
        }

        public Teacher(double salary, string subject) : this()
        {
            Salary = salary;
            Subject = subject;
        }

        public void Resign()
        {
            Console.WriteLine("{0} has resigned", FullName);
        }

        public void Teach()
        {
            Console.WriteLine("{0} teaches {1}",FullName,Subject);
        }

        public void MarkRegister()
        {
            Console.WriteLine("{0} is marking the class register ",FullName);
        }
        public override void Sit()
        {
            Console.WriteLine("I am sitting in the staff room");
        }

        public override void Walk()
        {
            Console.WriteLine("{0} am walking to the class", FullName);
        }

        public double Salary { get; protected set; }
        public string Subject { get; set; }
        public double CummulativeSalary { get; set; }
    }
}
