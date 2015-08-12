//	We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets 
//of several neighbour elements located on the same line, column or diagonal.
// Write a program that finds the longest sequence of equal strings in the matrix.
/*
   ha   fifi    ho  hi               result:
   fo   ha      hi  xx               ha, ha, ha
   xxx  ho      ha  xx      

   s    qq  s                        result:
   pp   pp  s                        s, s, s  
   pp   qq  s              
 
 */


using System;

class SequenceNMatrix
{
    static int bestCount = 0;
    static string[,] matrix;
    static string bestElement = string.Empty;

    private static void MakeMatrix(string[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("Please enter element[{0},{1}]:", row, col);
                matrix[row, col] = Console.ReadLine();
            }
        }
    }
    private static int FoundBestSequenceHorizonatally(string[,] matrix,int row,int col)
    {
        int count = 0;
        string bestElement = matrix[row,col];

        for (int i = col; i < matrix.GetLength(1); i++)
        {
            if (matrix[row, i] == bestElement)
            {
                ++count;
            }
            else
                break;
        }

        return count;
    }
    private static int FoundBestSequenceVertically(string[,] matrix,int row,int col)
    {
        int count = 0;
        string bestElement = matrix[row, col];

        for (int i = row; i < matrix.GetLength(0); i++)
        {
            if (matrix[i, col] == bestElement)
            {
                ++count;
            }
            else
                break;
        }

        return count;
    }
    private static int FoundBestSequenceDiagonal(string[,] matrix,int row,int col)
    {
        int count = 0;
        string bestElement = matrix[row, col];

        for (int i = row, j = col; i < matrix.GetLength(0) && j < matrix.GetLength(1); i++, j++)
        {
            if (matrix[i, j] == bestElement)
            {
              ++count;  
            }
            else
                break;
        }

        return count;
    }
    private static void CheckForSequence(string[,] matrix, int row, int col)
    {
        int horizontally =FoundBestSequenceHorizonatally(matrix, row, col);
        int vertically = FoundBestSequenceVertically(matrix, row, col);
        int diagonal = FoundBestSequenceDiagonal(matrix, row, col);

        if (diagonal > bestCount ||
            horizontally > bestCount ||
            vertically > bestCount)
        {
            bestCount = Math.Max(Math.Max(horizontally, diagonal), vertically);
            bestElement = matrix[row, col];
        }
    }
    private static void PrintBestElement(string bestElement,int bestCount)
    {
        Console.WriteLine("Best sequence is:");
        for (int i = 0; i < bestCount; i++)
        {
            Console.Write(i != bestCount - 1 ? bestElement + ", " : bestElement + "\n");
        }
        Console.WriteLine("{0}--->{1} times",bestElement,bestCount);
    }
    static void Main()
    {

        Console.Write("Please enter the first dimension of the matrix: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter the second dimension of the matrix: ");
        int m = int.Parse(Console.ReadLine());
        string[,] matrix = new string[n, m];

        MakeMatrix(matrix);

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                CheckForSequence(matrix, row, col);
            }
        }
        PrintBestElement(bestElement, bestCount);
       
       
    }
}

