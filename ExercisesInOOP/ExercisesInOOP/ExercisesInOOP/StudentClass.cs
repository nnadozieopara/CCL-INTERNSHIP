using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolModel
{
    public class StudentClass
    {
        public StudentClass()
        {
            TextID = "none yet";
        }

        public StudentClass(List<Teacher> teacherList):this()
        {
            TeacherList = teacherList;
        }
        public string TextID { get; set; }
        public List<Teacher> TeacherList { get; set; }
    }
}
