using System;
using System.Collections.Generic;

namespace HumanProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = { new Student(56), new Student(66.6), new Student(66), new Student(8.96), new Student(56),
                 new Student(12.7), new Student(30.48), new Student(45.7), new Student(76.8), new Student(96) };

             Array.Sort(students);

            Worker[] workers =
                {
                    new Worker(96m, 6), new Worker(576m, 6), new Worker(5126m, 6), new Worker(516m, 6),
                     new Worker(106m, 6), new Worker(156m, 6), new Worker(5116m, 6), new Worker(1256m, 6),
                      new Worker(556m, 6), new Worker(2356m, 6)
                };
            Array.Sort(workers);
            Worker[] descendingWageWorker = new Worker[10];
            for (int i = 0; i < 10; i++)
            {
                descendingWageWorker[i] = workers[9 - i];
            }
        }
    }
}
