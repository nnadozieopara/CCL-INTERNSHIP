using System;

namespace primeNumbersBetween1and10000000000
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static bool isPrime(int userNumber)
            {
                for (int i = 2; i < Math.Sqrt(userNumber) +1; i++)
                {
                    if (i == 2)
                    {
                        return true;
                    }
                    if (userNumber % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            
            for (int i = 1; i < 10000000; i++)
            {
                if (isPrime(i)==true)
                {
                    Console.Write("{0} ",i);
                }
            }
        }

        
    }
}
