using System;

namespace sequenceWithMaximalSum
{
    internal class sequenceWithMaximalSum
    {
        static void Main(string[] args)
        {
            int sum = 0, tempSum, index =0,tempIndex =0;

            Console.Write("Enter array length: ");
            int length = int.Parse(Console.ReadLine());

            int[] inputArray = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element: ", i+1);
                inputArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < length - 1; i++)
            {
                tempSum = inputArray[i];

                for (int j = i + 1; j < length; j++)
                {
                    tempSum += inputArray[j];
                    if (tempSum > sum)
                    {
                        sum = tempSum;
                        tempIndex = i;
                    }
                    else
                    {
                        index = tempIndex;
                    }
                    if (tempSum > sum && tempIndex > index)
                    {
                        index = tempIndex;
                    }
                }
            }
            Console.WriteLine("The member of the subsequence is listed below");
            int sumCheck = 0;
            while (sumCheck <= sum && index < length) 
            {
                sumCheck += inputArray[index];
                Console.Write("{0} ", inputArray[index]);
                index++;
            }

            //Console.WriteLine("Result is {0}. , index is {1}", sum, index);
        }
    }
}
