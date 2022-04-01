using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace RandomNumbersInARange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("this program prints random numbers repeatedly within a range until a certain number is printed");
            Console.Write("Enter lower bound of the range: ");
            int startValue = int.Parse(Console.ReadLine());
            Console.Write("Enter upper bound of the range: ");
            int endValue = int.Parse(Console.ReadLine());
            Console.Write("Enter the number which serves as a checker. checker must be between lower and upper bound: ");
            int checker = int.Parse(Console.ReadLine());
            if (startValue > endValue)
            {
                (endValue, startValue) = (startValue, endValue);
                PrintRandomNumbersInARange(startValue, endValue, checker);
            }
            else
            {
                PrintRandomNumbersInARange(startValue, endValue, checker);
            }

        }

        static void PrintRandomNumbersInARange(int startValue, int EndValue, int checkValue)
        {
            var rand = new Random();
            //List<int> randomNumbers = new List<int>();
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            int number = rand.Next(startValue, EndValue);
            while (number != checkValue)
            {
               // randomNumbers.Add(number);
                Console.WriteLine(number);
                number = rand.Next(startValue, EndValue);
            }
            Console.WriteLine(number);
            sw.Stop();
            Console.WriteLine("Elapsed Time is {0} ms", sw.ElapsedMilliseconds);
        }
    }
}
