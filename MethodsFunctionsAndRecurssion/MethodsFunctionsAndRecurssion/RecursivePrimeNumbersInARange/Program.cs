using System;

namespace RecursivePrimeNumbersInARange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintPrimeWithinRange(2, 100);
        }

        static bool IsPrime(int number)
        {
            if(number == 0 || number == 1)
            {
                return false;
            }
            else if(number == 2)
            {
                return true;
            }
            else
            {
                //int length = (int)Math.Sqrt(number);
                for (int i = 2; i < number; i++)
                {
                    if(number % i == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static void PrintPrimeWithinRange(int lowerBound, int upperBound)
        {
            
                if (lowerBound == upperBound)
                {
                   if(IsPrime(upperBound))
                   {
                        Console.WriteLine(upperBound);
                        return;
                   }

                }else if(lowerBound > upperBound)
                {
                return;
                }
                else
                {
                    if (IsPrime(lowerBound))
                    {
                        Console.WriteLine(lowerBound);
                    }
                    PrintPrimeWithinRange(lowerBound + 1, upperBound);
                }
        }
    }
}
