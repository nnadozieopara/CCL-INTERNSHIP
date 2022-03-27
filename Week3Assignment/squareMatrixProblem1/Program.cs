using System;

namespace squareMatrixProblem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter row: ");
            int row = int.Parse(Console.ReadLine());

            Console.Write("Enter column: ");
            int column = int.Parse(Console.ReadLine());
            int[,] inputArray = new int[row, column];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    inputArray[i, j] = i + 4 * j + 1;
                    Console.Write("{0} ",inputArray[i, j]);
                }
                Console.WriteLine();
            }
            
        }
    }
}
