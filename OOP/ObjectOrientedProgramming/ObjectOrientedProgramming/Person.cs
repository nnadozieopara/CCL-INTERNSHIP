using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    public abstract class Person
    {
        public Person()
        {
            FullName = "noName";
            Gender = "notStated";
            Age = null;
        }

        public Person(string fullName, string gender)
        {
            FullName = fullName;
            Gender = gender; 
        }

        public abstract void Walk();
        public abstract void Sit();
        public string FullName { get; set; }
        public string Gender { get; set; }
        public int? Age { get; set; }
    }
}
