using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolModel
{
    public class Teacher:People
    {
        public Teacher()
        {
            Name = "Teacher";
        }

        public Teacher(string name)
        {
            Name=name;
        }

        public override void GetdisciplinaryAction()
        {
            Console.WriteLine("Your salary will be reduced by 0.1%");
        }

        public void Teach(List<Course> course, Teacher teacher)
        {
            List<Course> courses = course;
            int length = courses.Count;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("{0} teaches {1}",teacher.Name, courses[i] );
            }
        }
    }
}
