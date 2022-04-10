using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneTransition
{
    public class Phone
    {
        public Phone():this("noName","noModel")
        {

        }
        public Phone(string name, string model)
        {
            Name = name;
            Model = model;
        }
        public string Name { get; set; }
        public string Model { get; set; }
    }
}
