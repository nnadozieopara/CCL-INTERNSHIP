using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolModel
{
    public abstract class People
    {
        public virtual void Move()
        {
            Console.WriteLine("Walk!");
        }
        public abstract void GetdisciplinaryAction();
        public string Name { get; set; }
    }
}
