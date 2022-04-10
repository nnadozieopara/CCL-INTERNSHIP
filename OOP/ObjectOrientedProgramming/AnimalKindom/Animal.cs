using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKindom
{
    public class Animal
    {
        public Animal()
        {

        }

        public Animal(string name)
        {
            Name = name;
        }

        public void Move()
        {
            Console.WriteLine("Moving in my own way");
        }
        public void Respirate()
        {
            Console.WriteLine("I am respirating");
        }
        public  void Respire()
        {
            Console.WriteLine("I am respirating");
        }
        public void Reproduce()
        {
            Console.WriteLine("I just produced another of my kind");
        }
        public string Name { get; set; }
    }
}
