using System;

namespace indicesOfLettersFromWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] latinAlphabets = 
                                    {
                                      'A', 'B','C','D','E','F','G','H','I','J','K','L',
                                      'M','N','O','P','Q','R', 'S','T','U','V','W','X','Y','Z'
                                     };

            Console.WriteLine(latinAlphabets.Length);

            Console.WriteLine("This program prints an array of the indicies of a word in the latin alphabets");
            Console.Write("Enter your word here: ");
            string userWords = Console.ReadLine().ToUpper();

            int lengthOfString = userWords.Length;

            int[] userWordIndex = new int[lengthOfString];
            for (int i = 0; i < lengthOfString; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    if (userWords[i]==latinAlphabets[j])
                    {
                        userWordIndex[i] = j + 1;
                        break;
                    }
                }
            }
            Console.Write("[ ");
            for (int i = 0; i < lengthOfString; i++)
            {
                if (i==lengthOfString -1)
                {
                    Console.Write(" {0} ]", userWordIndex[i]);
                }
                else
                {
                    Console.Write("{0} ,",userWordIndex[i]);
                }
                
            }
        }
    }
}
