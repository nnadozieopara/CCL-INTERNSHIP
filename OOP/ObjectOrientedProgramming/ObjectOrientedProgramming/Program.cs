using System;

namespace ObjectOrientedProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Teacher myTeacher = new Teacher();
            string name = myTeacher.FullName;
            Console.WriteLine(name); 

            Student myStudent = new Student(5,"Blue House");
            myStudent.Gender = "Male";
            myStudent.Age = 14;
            myStudent.FullName = "Chukwuma Adekunle Ciroma";
            myStudent.Sit();
            School newSchool = new School("Jubilee Model School");
            newSchool.AdmitStudent(myStudent);
            newSchool.EmployTeacher(myTeacher);
            newSchool.PaySalary(400000, myTeacher);
            Console.WriteLine(myTeacher.CummulativeSalary);
        }
    }
}
