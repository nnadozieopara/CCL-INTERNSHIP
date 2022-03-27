using System;

namespace maximalSequenceOfConsecutiveEqualElement
{
    internal class maximalSequenceOfConsecutiveEqualElement
    {
        static void Main(string[] args)
        {
            int bestIndex = 0;
            int bestCount = 0;
            int currentIndex = 0;
            int currentCount = 0;
            Console.WriteLine("enter your array");
            Console.Write("enter length of array: ");
            int length = int.Parse(Console.ReadLine());
            int[] inputArray = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write("inputArray[{0}]: ",i+1);
                inputArray[i] = int.Parse(Console.ReadLine());
            }


            for (int i = 0; i < length -1; i++)
            {
                if (inputArray[i] ==
                 inputArray[i + 1])
                {
                    currentCount++;
                    if (currentCount > bestCount)
                    {
                        bestCount =
                         currentCount;
                        bestIndex =
                        currentIndex;
                    }
                }
                else
                {
                    currentCount = 1;
                    currentIndex = i + 1;
                }
            }
            Console.Write("{");
            for (int k = bestIndex; k < bestIndex + bestCount; k++)
            {
                if (k == bestIndex + bestCount - 1)
                {
                    Console.Write("{0}",inputArray[k]);
                    Console.Write("}");
                }
                else
                {
                    Console.Write("{0}, ", inputArray[k]);
                }
            }    
        }
    }
}
