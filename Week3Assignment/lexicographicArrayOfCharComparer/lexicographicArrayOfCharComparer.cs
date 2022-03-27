using System;

namespace lexicographicArrayOfCharComparer
{
    internal class lexicographicArrayOfCharComparer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program compares two arrays of type char lexicographically");
            Console.Write("Enter the length of your first array: ");
            int firstLength = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter the characters in your first array");
            char[] firstArray = new char[firstLength];
            for (int i = 0; i < firstLength; i++)
            {
                Console.Write("Enter firstArray[{0}]: ", i + 1);
                firstArray[i] =char.ToLower( char.Parse(Console.ReadLine()));
            }

            Console.Write("\nEnter the length of your second array: ");
            int secondLength = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter the characters in your first array");
            char[] secondArray = new char[secondLength];
            for (int i = 0; i < secondLength; i++)
            {
                Console.Write("Enter firstArray[{0}]: ", i + 1);
                secondArray[i] = char.ToLower(char.Parse(Console.ReadLine()));
            }

            int length = firstLength < secondLength ? firstLength : secondLength;
            for (int i = 0; i < length; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    if (i == length -1 && firstLength < secondLength)
                    {
                        Console.WriteLine("firstArray comes first lexicographically");
                        break;
                    }
                    else if(i == length - 1)
                    {
                        Console.WriteLine("firstArray is lexicographically equal to secondArray");
                    }
                    continue;
                }
                else if (firstArray[i] < secondArray[i])
                {
                    Console.WriteLine("firstArray comes first lexicographically");
                    break;
                }
                else
                {
                    Console.WriteLine("secondArray comes first lexicographically");
                }
            }
        }
    }
}
