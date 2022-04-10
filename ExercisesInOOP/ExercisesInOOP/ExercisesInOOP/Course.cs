using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolModel
{
    public class Course
    {
        public Course()
        {
            Name = "courseTitle";
            CountOfClass = 0;
            CountOfExercises = 0;
        }

        public Course(string courseTitle):this()
        {
            Name=courseTitle;
        }
        public string Name { get; set; }
        public int CountOfClass { get; set; }
        public int CountOfExercises { get; set; }
    }
}
