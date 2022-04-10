using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProject
{
    public class Kitten:Animal
    {
        public Kitten(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Miaaau! Miaaau!");
        }
    }
}
