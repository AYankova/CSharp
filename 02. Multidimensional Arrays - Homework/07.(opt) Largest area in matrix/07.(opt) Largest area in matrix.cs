//Write a program that finds the largest area of equal neighbour elements in a rectangular matrix and prints its size.

using System;

class MatrixClass
{
    static int[,] matrix;
    static int bestLen = 0;
    static int bestElement;
    static int element;
    static int len=0;

    private static void FindTheArea(int[,] matrix)
    {
        bestLen = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                len = 0;
                element = matrix[row, col];
                GetLength(row, col);
                if (len>bestLen)
                {
                    bestLen = len;
                    bestElement = element;
                }
            }
        }
        Console.WriteLine("Number {0} is the most sequential number and is present {1} times in the matrice!", bestElement, bestLen);
    }
    private static void GetLength(int row,int col)
    {
        if (row < 0 || row >= matrix.GetLength(0) || col < 0 || col >= matrix.GetLength(1) || matrix[row, col] == int.MinValue)
        {
            return;
        }
        if (matrix[row,col]==element)
        {
            matrix[row, col] = int.MinValue;//we don't need this value anymore, so we change it
            len++;

            GetLength(row - 1, col);
            GetLength(row + 1, col);
            GetLength(row, col - 1);
            GetLength(row, col + 1);
        }
    }

    static void Main()
    {
        matrix = new[,]        //working with the example;change if you want
		{
			{ 1, 3, 2, 2, 2, 4 },
			{ 3, 3, 3, 2, 4, 4 },
			{ 4, 3, 1, 2, 3, 3 },
			{ 4, 3, 1, 3, 3, 1 },
			{ 4, 3, 3, 3, 1, 1 }
		};

        FindTheArea(matrix);
    }
}