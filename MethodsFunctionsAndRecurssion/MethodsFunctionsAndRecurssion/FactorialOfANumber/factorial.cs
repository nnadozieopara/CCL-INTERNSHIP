using System;

namespace FactorialOfANumber
{
    internal class factorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program calculates the factorial of a given none zero integer number");
            Console.Write("Enter the integer number: ");
            int inputNumber = int.Parse(Console.ReadLine());
            if (inputNumber < 0)
            {
                Console.WriteLine("Invalid number");
                return;
            }
            else
            {
                int factorial = CalculateFactorialOfNumber(inputNumber);
                Console.WriteLine("The factorial of {0} is {1}", inputNumber, factorial);
            }
        }
        static int CalculateFactorialOfNumber(int number)
        {
            int factorial = 1;
            if (number ==0)
            {
                return factorial;
            }
            else
            {
                while (number > 0)
                {
                    factorial *= number;
                    number--;
                }
            }
            return factorial;
        }
    }
}
