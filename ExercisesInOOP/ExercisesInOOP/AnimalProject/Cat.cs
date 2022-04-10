using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProject
{
    public class Cat:Animal
    {
        public Cat(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Meow! Meow!");
        }
    }
}
