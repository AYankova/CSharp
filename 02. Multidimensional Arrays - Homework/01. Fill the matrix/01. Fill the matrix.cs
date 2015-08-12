//Write a program that fills and prints a matrix of size (n, n) 

using System;

class FillTheMatrix
{
    static void Main()
    {
        Console.WriteLine("Please enter the size of the matrix:");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Solution A:");
        MatrixA(matrix);
        PrintMatrix(matrix);
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Solution B:");
        MatrixB(matrix);
        PrintMatrix(matrix);
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Solution C:");
        MatrixC(matrix);
        PrintMatrix(matrix);
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Solution D:");
        MatrixD(matrix);
        PrintMatrix(matrix);
        Console.WriteLine();

    }
    private static void MatrixA(int[,] matrix)
    {
        int j = 1;
        int n=matrix.GetLength(1);
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = j;
                j += n;
                if (col == n - 1)
                {
                    j = row + 2;
                }
            }
        }
    }
    private static void MatrixB(int[,] matrix)
    {
        int index = 1;
        int n = matrix.GetLength(1);

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            int innerElseIndex = (col + 1) * n;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (col % 2 == 0)
                {
                    matrix[row, col] = index;
                }
                else
                {
                    matrix[row, col] = innerElseIndex;
                    innerElseIndex--;
                }
                index++;
            }
        }
    }
      private static void MatrixC(int[,] matrix)
    {
        int counter = 1;
        int maxCounter = matrix.GetLength(0) * matrix.GetLength(1);
        int tempRow = 1;
        int tempCol = 0;

        for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
        {
            for (int column = 0; column < matrix.GetLength(1); )
            {
                matrix[row, column] = counter;
                if (counter == maxCounter)
                {
                    break;
                }
                else if (row == matrix.GetLength(0) - 1 && column != matrix.GetLength(1) - 1)
                {
                    row -= tempRow;
                    column -= tempCol;
                    tempRow++;
                    tempCol++;
                }
                else if (row == matrix.GetLength(0) - 1 || column == matrix.GetLength(1) - 1)
                {
                    tempCol--;
                    tempRow--;
                    row -= tempRow;
                    column -= tempCol;
                }
                else
                {
                    row++;
                    column++;
                }
                counter++;

            }

        }
    }
    private static void MatrixD(int[,] matrix)
      {
          int left = 0;
          int right =matrix.GetLength(1) - 1;
          int up = 0;
          int down = matrix.GetLength(0) - 1;
          int counter = 1;
          do
          {
              for (int i = up; i <= down; i++)
              {
                  matrix[i, left] = counter;
                  counter++;
              }
              left++;

              for (int i = left; i <= right; i++)
              {
                  matrix[down, i] = counter;
                  counter++;
              }
              down--;

              for (int i = down; i >= up; i--)
              {
                  matrix[i, right] = counter;
                  counter++;
              }
              right--;

              for (int i = right; i >= left; i--)
              {
                  matrix[up, i] = counter;
                  counter++;
              }
              up++;

          } while (counter <= matrix.GetLength(0) * matrix.GetLength(1));
      }
    private static void PrintMatrix(int[,] matrix)
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
                    Console.WriteLine(matrix[row, col]);
                }
            }
        }
    }
}