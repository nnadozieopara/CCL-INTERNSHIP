using System;

namespace StringCharacter
{
    internal class StringNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program gives the number of characters in a given string");
            Console.Write("Enter your string: ");
            string inputString = Console.ReadLine();
            Console.WriteLine("The number of characters in {0} is {1}", inputString,FindNumberOfStringCharacter(inputString));
        }
        static int FindNumberOfStringCharacter(string inputString)
        {
            return inputString.Length;
        }
    }
}
