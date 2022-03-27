using System;

namespace selectionSort
{
    internal class selectionSort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("this program will sort your array of numbers using the selection sort algotithm");
            Console.Write("Enter the size of your array: ");
            int length = int.Parse(Console.ReadLine());
            double[] inputArray = new double[length];

            Console.WriteLine("Enter  your array elements");
            for (int i = 0; i < length; i++)
            {
                Console.Write("inputArray[{0}]: ", i + 1);
                inputArray[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < length - 1; i++)
            {
                int minIndex = i;
                for (int j = i+1; j < length; j++)
                {
                    if (inputArray[j] < inputArray[minIndex])
                    {
                        minIndex = j;
                    }
                }
                double temp = inputArray[minIndex];
                inputArray[minIndex] = inputArray[i];
                inputArray[i] = temp;
            }
            Console.Write("[ ");
            for (int i = 0; i < length; i++)
            {
                if (i == length - 1)
                {
                    Console.Write("{0} ]", inputArray[i]);
                }
                else
                {
                    Console.Write("{0}, ", inputArray[i]);
                }
               
            }
        }
    }
}
