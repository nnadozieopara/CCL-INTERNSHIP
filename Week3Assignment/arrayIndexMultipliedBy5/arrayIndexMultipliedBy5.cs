using System;

namespace arrayIndexMultipliedBy5
{
    internal class arrayIndexMultipliedBy5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program takes in the size of the array initialises the" +
                "value at each index using 5 * index");
            Console.Write("Enter the size of your desired array: ");
            int length = int.Parse(Console.ReadLine());
            int[] myArray = new int[length];
            Console.Write("[");
            for (int i = 0; i < length; i++)
            {
                myArray[i] = 5 * i;
                if (i<length - 1)
                {
                    Console.Write(myArray[i] +", ");

                }
                else
                {
                    Console.Write(myArray[i] + "]");
                }
            }
        }
    }
}
