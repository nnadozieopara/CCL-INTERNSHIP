using System;

namespace equalArrayChecker
{
    internal class EqualArrayChecker
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program checks if two arrays are the same.\nTwo arrays are thesame if they are first of the same length" +
                            ", data type and their values at each index are the same. Here, we consider integer data type");
            Console.Write("Enter the length of your first array: ");
            int firstLength = int.Parse(Console.ReadLine());
            int[] firstArray = new int[firstLength];
            Console.WriteLine("Enter integer numbers to populate your first array");
            for (int i = 0; i < firstLength; i++)
            {
                Console.Write("firstArray[{0}]: ", i + 1);
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter the length of your second array: ");
            int secondLength = int.Parse(Console.ReadLine());
            int[] secondArray = new int[firstLength];
            Console.WriteLine("Enter integer numbers to populate your second array");
            for (int i = 0; i < secondLength; i++)
            {
                Console.Write("secondArray[{0}]: ", i + 1);
                secondArray[i] = int.Parse(Console.ReadLine());
            }



            if(firstLength != secondLength)
            {
                Console.WriteLine("the two arrays are not equal");
            }
            else
            {
                for (int i = 0; i < firstLength; i++)
                {
                    if (firstArray[i] != secondArray[i])
                    {
                        Console.WriteLine("the two arrays are not equal");
                        break;
                    }
                    else if (i == firstLength -1)
                    {
                        Console.WriteLine("the two arrays are equal");
                    }
                }
            }
        }
    }
}
