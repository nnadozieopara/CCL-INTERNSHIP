using System;

namespace sumOfSequenceEqualToACertainNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("find a sequence of neighbor numbers in an array," +
                "which has a sum of certain number S.Example: { 4, 3, 1, 4, 2, 5, 8}" +
                ",S = 11 => { 4, 2, 5}");
            int sum = 0, startIndex = 0, endIndex = 0;
            bool sumFound = false;

            Console.Write("Enter the desired Sum: ");
            int s = int.Parse(Console.ReadLine());

            Console.Write("Enter array length: ");
            int length = int.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter Sequence Element {0}: ", i+1);
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < length - 1; i++)
            {
                sum = arr[i];

                for (int j = i + 1; j < length; j++)
                {
                    sum += arr[j];
                    if (sum == s)
                    {
                        startIndex = i;
                        endIndex = j;
                        sumFound = true;
                        break;
                    }
                }

                if (sumFound)
                {
                    break;
                }
            }

            if (sumFound)
            {
                Console.Write("[ ");
                for (int i = startIndex; i <= endIndex; i++)
                {
                    if (i== endIndex)
                    {
                        Console.Write("{0} ]", arr[i]);
                    }
                    else
                    {
                        Console.Write("{0}, ", arr[i]);
                    }
                    
                }
            }
            else Console.WriteLine("No sum found.");
        }
    }
}
