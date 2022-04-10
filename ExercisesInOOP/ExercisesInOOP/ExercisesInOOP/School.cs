using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolModel
{
    public class School
    {
        public School()
        {

        }
        public School(string name, List<StudentClass> myClassesOStudents)
        {
            Name = name;
            Classes = myClassesOStudents;
        }

        public void EmployTeacher( Teacher teacher)
        {
            NumberOfTeachers++;
            Console.WriteLine("Dear {0}, congratulations! You have been employed", teacher.Name);
        }

        public void AdmitStudent(Students student)
        {
            NumberOfStudents++;
            Console.WriteLine("Dear {0}, congratulations! You have been employed", student.Name);
        }
        public int NumberOfTeachers { get; set; }
        public int NumberOfStudents { get; set; }
        public string Name { get; set; }    
        public List<StudentClass> Classes { get; set; }
    }
}
