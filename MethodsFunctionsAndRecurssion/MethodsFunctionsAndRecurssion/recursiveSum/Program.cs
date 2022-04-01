using System;

namespace recursiveSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This function calculates the sum of integer numbers less than or equal to a given input number.");
            Console.Write("Enter your input number : ");
            int inputNumber = int.Parse(Console.ReadLine());
            int sumOfValues = SumOfValues(inputNumber);
            Console.WriteLine("The sum of integer numbers less than or equal to {0} is {1} ",inputNumber, sumOfValues);
        }
        static int SumOfValues(int number)
        {
            if (number ==0)
            {
                return 0;
            }
            else
            {
                int sum = number + SumOfValues(number - 1);
                return sum;
            }
        }
    }
}
