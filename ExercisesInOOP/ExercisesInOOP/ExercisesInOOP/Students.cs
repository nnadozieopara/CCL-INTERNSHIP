using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolModel
{
    public class Students:People
    {
        public Students()
        {
            Name = "Student";
        }
        public Students(string name, int uniqueId)
        {
            Name = name;
            UniqueID = uniqueId;
        }
        public int UniqueID { get; set; }

        public override void GetdisciplinaryAction()
        {
            Console.WriteLine("You are suspended for three days");
        }

        public override void Move()
        {
            Console.WriteLine("Use School bus to move");
        }
    }
}
