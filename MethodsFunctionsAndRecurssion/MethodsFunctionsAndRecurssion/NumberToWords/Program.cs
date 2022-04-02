using System;

namespace NumberToWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConvertNumberToWords(45);
        }
        static void ConvertNumberToWords(int number)
        {
            string[] num = { "zero", "one", "two", "three", "four", "five", "six", "seven", "ight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tens = { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            if (number < 20)
            {
                Console.WriteLine(num[number]);
            }
            else if (number >=20 && number < 100)
            {
                int unit = number % 10;
                int ten = number / 10;
                string result = tens[ten - 2] + (unit > 0 ? "-" + num[unit] : "");
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("One hundred");
            }
        }
    }
}
