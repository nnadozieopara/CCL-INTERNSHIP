using System;

namespace SolveQuadraticEquation
{
    internal class SolveQuadraticEquation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This function solves any given quadratic equation with real roots");
            Console.Write("Enter 'a', the coefficient of x^2: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter 'b' the coefficient of x: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter the value of the constant c: ");
            double c = double.Parse(Console.ReadLine());

            double[] solutionOfTheEquation = SolveQuadraticEquations(a, b, c);
            

            Console.WriteLine("The solution of the quadratic equation is {0} and {1}", solutionOfTheEquation[0], solutionOfTheEquation[1]);
        }

        static double[] SolveQuadraticEquations(double a, double b, double c)
        {
            double[] result = { 0, 0 };
            double discriminant = (b * b) - (4 * a * c);
            if (discriminant >= 0)
            {
                double squareRootOfDiscriminant = Math.Sqrt(discriminant);
                result[0] = (-b + squareRootOfDiscriminant) /( 2 * a);
                result[1] = (-b - squareRootOfDiscriminant) / (2 * a);
            }
            else
            {
                result[0] = double.NaN;
                result[1] = double.NaN;
            }

            return result;
        }
    }
}
