//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of 
//its elements.

using System;

class MaximalSum
{
    private static void MakeMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("Please enter element[{0},{1}]:",row,col);
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }
    }
    private static void PrintArea(int startRow,int startCol,int[,] matrix)
    {
        for (int i = startRow; i < startRow+3; i++)
        {
            for (int j = startCol; j < startCol+3; j++)
            {
                Console.Write(matrix[startRow,startCol]+", ");
                Console.WriteLine();
            }
        }
    }
    private static void FindArea3x3WithBestSum(int[,] matrix)
    {
        int bestSum = int.MinValue;
        int startRow = 0;
        int startCol = 0;
      
        for (int row = 0; row < matrix.GetLength(0)-2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1)-2; col++)
            {
                int sum = matrix[row, col] + matrix[row + 1, col] + matrix[row + 2, col] + matrix[row, col + 1] + matrix[row + 1, col + 1] + matrix[row + 2, col + 1]
                    + matrix[row, col+2] + matrix[row+1, col+2] + matrix[row+2, col+2];
                if (sum>bestSum)
                {
                    bestSum = sum;
                    startCol = col;
                    startRow = row;
                    
                }
            }
        }
        for (int i = startRow; i <startRow +3; i++)
        {
            for (int j = startCol; j < startCol+3; j++)
            {
                if (j!=startCol+2)
                {
                  Console.Write("{0,5}",matrix[i, j] + ", ");  
                }
                else
	            {
                    Console.Write("{0,5}",matrix[i,j]);
	            }
            }
            Console.WriteLine();

        }
        Console.WriteLine("The maximal sum of elements 3x3 from the matrix is: {0}", bestSum);
    }
    private static void OriginalMatrix(int[,] matrix)
    {
        int n = matrix.GetLength(1);
        for (int row = 0; row <matrix.GetLength(0); row++)
        {
            for (int col = 0; col <matrix.GetLength(1); col++)
            {
                if (col != n - 1)
                {
                    Console.Write("{0,5}", matrix[row, col] + ", ");
                }
                else
                {
                    Console.Write("{0,5}",matrix[row, col]+"\n");
                }
            }
        }
    }
    
    static void Main()
    {
        Console.Write("Please enter the first dimension of the matrix: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter the second dimension of the matrix: ");
        int m = int.Parse(Console.ReadLine());
        int[,] matrix=new int[n,m];

        if (n<3||m<3)
        {
            throw new ArgumentOutOfRangeException("dimensions of matrix-N and M","Must be greater than 3!");
        }
        else
        {
        MakeMatrix(matrix);
        Console.Clear();
        Console.WriteLine("Original matrix:");
        OriginalMatrix(matrix);
        Console.WriteLine("The area with max sum:");
        FindArea3x3WithBestSum(matrix);
        }
    }
}

