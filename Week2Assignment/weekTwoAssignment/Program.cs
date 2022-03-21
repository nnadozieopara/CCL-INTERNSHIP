using System;

namespace weekTwoAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AssignmentOne();
            FixedQuadratic();
            DynamicQuadratic();
        }
        static void AssignmentOne()
        {
            //Assignment 3
            int nExponent = 0;
            int wExponent = 0;
            int fValue = 0;
            int sValue = 0;
            int lValue = 0;
            double firstTerm = (sValue * lValue) / fValue;
            double secondTerm = (20 / fValue) ^ wExponent;
            double yValue = lValue - ((fValue ^ nExponent) * (firstTerm + secondTerm)) / (20 ^ nExponent);

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

        static void FixedQuadratic()
        {
            Console.WriteLine("what kind of root does the equation X^2 + 6X + 5 = 0 have?");
            int a = 1;
            int b = 6;
            int c = 5;
            double discriminant = (b ^ 2) - (4 * a * c);
            if(discriminant > 0)
            {
                Console.WriteLine("real roots");
            }
            else if (discriminant < 0)
            {
                Console.WriteLine("complex roots");
            }
            else
            {
                Console.WriteLine("equal roots");
            }
        }

        static void DynamicQuadratic()
        {
            Console.WriteLine("This function tells you the nature of the roots of your input quadratic equation \n" +
                "Your quadratic equation is of the form aX^2 + bX + c = 0 ");
            Console.Write("enter the value of a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("enter the value of b:");
            double b = double.Parse(Console.ReadLine());
            Console.Write("enter the value of c:");
            double c = double.Parse(Console.ReadLine());
            double discriminant = (b * b) - (4 * a * c);

            if (discriminant > 0)
            {
                Console.WriteLine("real roots"); ;
            }
            else if (discriminant < 0)
            {
                Console.WriteLine("complex roots");
            }
            else
            {
                Console.WriteLine("equal roots"); ;
            }
        }
    }

 
}

