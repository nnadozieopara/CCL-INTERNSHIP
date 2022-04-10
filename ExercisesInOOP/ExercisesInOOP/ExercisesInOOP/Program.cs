using System;

namespace SchoolModel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course mycourse = new Course("Maths");
            Console.WriteLine(mycourse.CountOfClass);
            Console.WriteLine(mycourse.CountOfExercises);

        }
    }
}
