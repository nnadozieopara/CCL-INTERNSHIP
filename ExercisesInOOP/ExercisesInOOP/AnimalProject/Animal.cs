using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProject
{
    public abstract class Animal
    {

        public virtual void MakeSound()
        {
            Console.WriteLine("Hei! Hei!");
        }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

    }
    
}
