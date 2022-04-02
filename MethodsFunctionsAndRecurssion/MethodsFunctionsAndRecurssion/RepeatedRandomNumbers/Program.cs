using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace RepeatedRandomNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintRandomNumbersInARange(2, 6);
        }
        static void PrintRandomNumbersInARange(int startValue, int EndValue)
        {
            var rand = new Random();
            Stopwatch sw = Stopwatch.StartNew();
            List<int> randomNumbers = new List<int>();
            sw.Start();
            int number = rand.Next(startValue, EndValue);
            while (!randomNumbers.Contains(number))
            {
                Console.WriteLine(number);
                randomNumbers.Add(number);
                number = rand.Next(startValue, EndValue);
            }
            Console.WriteLine(number);
            sw.Stop();
            Console.WriteLine("Elapsed Time is {0} ms", sw.ElapsedMilliseconds);
        }
    }
}
