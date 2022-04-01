using System;

namespace RecursiveStringLength
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program determines the length of string using recursive action");
            Console.Write("Enter your input string: ");
            string userInput = Console.ReadLine();
            int lengthOfString = CalculateLengthOfString(userInput);
            Console.WriteLine("The length of characters in the sting {0} is {1}",userInput,lengthOfString);
        }
        static int CalculateLengthOfString(string userStringInput)
        {
            if (userStringInput == "")
            {
                return 0;
            }
            else
            {
                return CalculateLengthOfString(userStringInput.Substring(1)) + 1;
            }
        }
    }
}
