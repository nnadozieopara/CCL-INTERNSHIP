using System;

namespace AnimalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = { new Cat("bob", 3), new Tomcat("Tricy", 5), new Kitten("lyn", 7), new Frog("max",2),
            new Dog("jack",6)};
            int length = animals.Length;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(animals[i].Age);
                Console.WriteLine(animals[i].Name);
                animals[i].MakeSound();
            }
        }
    }
}
