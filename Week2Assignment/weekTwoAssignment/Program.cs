using System;

namespace weekTwoAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignment 3
            int nExponent = 0;
            int wExponent = 0;
            int fValue = 0;
            int sValue = 0;
            int lValue = 0;
            double firstTerm = (sValue * lValue) / fValue;
            double secondTerm = (20 / fValue) ^ wExponent;
            double yValue = lValue - ((fValue ^ nExponent) * (firstTerm + secondTerm)) / (20 ^nExponent);

            //Assignment 4

            int a = 10, b = 20, c = 30;
            if (a == b)
            {
                Console.WriteLine("a > b");
            }

            if (c > a + b - c)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            if (c - b == a)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            if (a == b && c == a + b - c && c - b == a)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
