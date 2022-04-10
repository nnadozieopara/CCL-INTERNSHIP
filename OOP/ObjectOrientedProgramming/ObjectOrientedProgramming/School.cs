using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    public class School
    {
        public School()
        {
            NumberOfStudents = 0;
            NumberOfTeachers = 0;
        }
        public School(string nameOfSchool):this()
        {
            NameOfSchool = nameOfSchool;
        }

        public void EmployTeacher(Teacher teacherName)
        {
            NumberOfTeachers++;
            Console.WriteLine("{0} has been employed",teacherName.FullName);
        }

        public void SackTeacher(Teacher teacherName)
        {
            if (NumberOfTeachers > 0)
            {
                NumberOfTeachers--;
                Console.WriteLine("{0} has been sacked", teacherName.FullName);
            }
            else
            {
                Console.WriteLine("There is no teacher to sack");
            }
        }

        public void AdmitStudent(Student student)
        {
            Console.WriteLine("{0} has been admitted", student.FullName);
            NumberOfStudents++;
        }

        public void ExpelStudent(Student student)
        {
            if (NumberOfStudents > 0)
            {
                Console.WriteLine("{0} has been expelled", student.FullName);
                NumberOfStudents--;
            }
        }

        public void PaySalary(double amount, Teacher teacherName)
        {
            teacherName.CummulativeSalary += amount;
            Console.WriteLine("{0} has recieved =N={1}", teacherName.FullName, amount);
        }

        public string NameOfSchool { get; set; }
        public int NumberOfStudents { get; set; }
        public int NumberOfTeachers { get; set; }

    }
}
