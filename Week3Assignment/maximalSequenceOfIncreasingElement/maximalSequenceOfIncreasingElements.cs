using System;

namespace maximalSequenceOfIncreasingElement
{
    internal class maximalSequenceOfIncreasingElements
    {
        static void Main(string[] args)
        {
            int counter = 0, tempIndex, tempCounter;

            Console.Write("Enter array length: ");
            int length = int.Parse(Console.ReadLine());
            //declaring input array (arr) and the result array
            int[] arr = new int[length];
            int[] result = new int[length];
            //populating the input array
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < length; i++)
            {
                int[] tempResult = new int[length];
                tempIndex = 1;
                tempCounter = 1;
                tempResult[0] = arr[i];
                //stating j at i+1 because we are moving to the right
                for (int j = i + 1; j < length; j++)
                {
                    if (arr[j] > tempResult[tempIndex - 1])
                    {
                        tempResult[tempIndex] = arr[j];
                        tempIndex++;
                        tempCounter++;
                    }
                    else if (tempIndex > 1 && arr[j] > tempResult[tempIndex - 2] && arr[j] < tempResult[tempIndex - 1])
                    {
                        tempResult[tempIndex - 1] = arr[j];
                    }
                }

                if (counter < tempCounter)
                {
                    counter = tempCounter;
                    result = tempResult;
                }
            }

            for (int i = 0; i < counter; i++) Console.Write("{0},", result[i]);
        }
    }
}
