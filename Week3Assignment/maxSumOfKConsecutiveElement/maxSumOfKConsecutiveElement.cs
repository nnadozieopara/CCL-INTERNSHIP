using System;

namespace maxSumOfKConsecutiveElement
{
    internal class maxSumOfKConsecutiveElement
    {
        static void Main(string[] args)
        {
            Console.Write("reads from the console two integer numbers N and K(K < N) and array of N integers.Find those K consecutive " +
                "elements in the array, which have maximal sum");
            Console.Write("Enter the value of N: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Enter the value of K: ");
            int K = int.Parse(Console.ReadLine());
            int[] inputArray = new int[N];

            Console.WriteLine("Populate your array that has N elements");
            for (int i = 0; i < N; i++)
            {
                Console.Write("enter array[{0}]: ", i + 1);
                inputArray[i] = int.Parse(Console.ReadLine());

            }

            int maximalSum = 0;
            int maxIndex = 0;

            for (int i = 0; i <= N - K; i++)
            {
                int sum = 0;
                for (int j = i; j <i+ K ; j++)
                {
                    sum += inputArray[j];
                }
                if (sum > maximalSum)
                {
                    maximalSum = sum;
                    maxIndex = i;
                }
                
                
            }
            Console.Write("[ ");
            for (int i = maxIndex; i < maxIndex+K; i++)
            {
                if (i == maxIndex +K -1)
                {
                    Console.Write("{0} ]", inputArray[i]);
                }
                else
                {
                    Console.Write("{0}, ",inputArray[i]);
                }
            }
            Console.WriteLine("maximal sum{0} maxIndex {1}", maximalSum, maxIndex);
        }
    }
}
