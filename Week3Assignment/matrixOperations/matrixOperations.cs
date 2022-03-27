using System;

namespace matrixOperations
{
    internal class matrixOperations
    {
        static void Main(string[] args)
        {
            int[,] matrixA = new int[3, 3];
            int[,] matrixB = new int[3, 3];
            Console.WriteLine("this program carries out the operation of addition, subtraction and multiplication on two 3 by 3 matrices of your choice \n");
            Console.WriteLine("Enter values for your first array, matrix A");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("\nEntering values in row {0} ", i+1);
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Enter value for matrixA[{0},{1}]: ", i+1, j+1);
                    matrixA[i,j] = int.Parse(Console.ReadLine());
                }

            }

            Console.WriteLine("\nEnter values for your first array, matrix B");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Entering values in row {0}", i + 1);
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Enter value for matrixB[{0},{1}]: ", i + 1, j + 1);
                    matrixB[i, j] = int.Parse(Console.ReadLine());
                }

            }

            int[,] matrixAdditionOfAandB = new int[3,3];
            for (int i = 0; i < matrixAdditionOfAandB.GetLength(0); i++)
            {
                for (int j = 0; j < matrixAdditionOfAandB.GetLength(1); j++)
                {
                    matrixAdditionOfAandB[i,j] = matrixA[i,j] + matrixB[i,j];
                }
            }

            int[,] matrixSubtractionOfAandB = new int[3, 3];
            for (int i = 0; i < matrixAdditionOfAandB.GetLength(0); i++)
            {
                for (int j = 0; j < matrixAdditionOfAandB.GetLength(1); j++)
                {
                    matrixSubtractionOfAandB[i, j] = matrixA[i, j] - matrixB[i, j];
                }
            }

            int[,] matrixMultiplicationOfAandB = new int[3, 3];
            int temp;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    temp = matrixAdditionOfAandB[i, j];
                    for (int k = 0; k < 3; k++)
                    {
                        temp += matrixA[i, k] * matrixB[k, j];
                    }
                    matrixMultiplicationOfAandB[i, j] = temp;
                }
            }

            int determinantOfMatrixA = 0;
            for (int i = 0; i < 3; i++)
            {
                determinantOfMatrixA += (matrixA[0, i] * (matrixA[1, (i + 1)%3] * matrixA[2, (i + 2) % 3]) - matrixA[1, (i + 2) % 3] * matrixA[2, (i + 1) % 3]);
            }

            int determinantOfMatrixB = 0;
            for (int i = 0; i < 3; i++)
            {
                determinantOfMatrixB += (matrixB[0, i] * (matrixB[1, (i + 1) % 3] * matrixB[2, (i + 2) % 3]) - matrixB[1, (i + 2) % 3] * matrixB[2, (i + 1) % 3]);
            }
            Console.Clear();

            Console.WriteLine("\nThe sum of your input matrices is given below:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    
                    Console.Write(matrixAdditionOfAandB[i, j] + " ");
                }
                Console.WriteLine();

            }

            Console.WriteLine("\nThe difference of your input matrices is given below:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    Console.Write(matrixSubtractionOfAandB[i, j] + " ");
                }
                Console.WriteLine();

            }

            Console.WriteLine("\nThe product of your input matrices is given below:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    Console.Write(matrixMultiplicationOfAandB[i, j] + " ");
                }
                Console.WriteLine();

            }

            if (determinantOfMatrixA > determinantOfMatrixB)
            {
                Console.WriteLine("The determinant of the matrixA is greater than the determinant of matrixB");
            }
            else if(determinantOfMatrixA < determinantOfMatrixB)
            {
                Console.WriteLine("The determinant of the matrixB is greater than the determinant of matrixA");
            }
            else
            {
                Console.WriteLine("The determinants of both matrix are equal");
            }
        }
    }
}
