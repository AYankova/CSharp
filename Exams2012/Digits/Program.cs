using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Program
    {
        static void Main()
        {
            int n =int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string currentLine = Console.ReadLine().Replace(" ","");
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentLine[col]-'0';
                }
            }
            int result = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    switch (matrix[i,j])
                    {
                        case 1: result += CheckForOne(matrix, i, j); break;
                        case 2: result += CheckForTwo(matrix, i, j); break;
                        case 3: result += CheckForThree(matrix, i, j); break;
                        case 4: result += CheckForFour(matrix, i, j); break;
                        case 5: result += CheckForFive(matrix, i, j); break;
                        case 6: result += CheckForSix(matrix, i, j); break;
                        case 7: result += CheckForSeven(matrix, i, j); break;
                        case 8: result += CheckForEight(matrix, i, j);break;
                        case 9: result += CheckForNine(matrix, i, j);break;
                        
                            
                    }
                }
            }
            Console.WriteLine(result);
        }
        private static int CheckForOne(int[,] matrix, int row,int col)
        {
            bool foundOne = row >= 0 && row < matrix.GetLength(0) - 4 && col >= 2 && col < matrix.GetLength(1) &&
                matrix[row, col] == 1 && matrix[row + 1, col - 1] == 1 && matrix[row + 2, col - 2] == 1 && matrix[row + 1, col] == 1 &&
                matrix[row + 2, col] ==1 && matrix[row + 3, col] == 1 && matrix[row + 4, col]== 1;
            return foundOne ? 1 : 0;
        }
        private static int CheckForTwo(int[,] matrix, int row,int col)
        {
            bool foundTwo = row >= 0 && row < matrix.GetLength(0)-4 && col >= 1 && col < matrix.GetLength(1) - 1 &&
                matrix[row, col] == 2 && matrix[row + 1, col - 1] == 2 && matrix[row + 1, col + 1] == 2 && matrix[row + 2, col + 1] == 2 &&
                matrix[row + 3, col] == 2 && matrix[row + 4, col - 1] == 2 && matrix[row + 4, col] == 2 && matrix[row + 4, col + 1] == 2;
            return foundTwo ? 2 : 0;
        }
        private static int CheckForThree(int[,] matrix, int row,int col)
        {
            bool foundThree = row >= 0 && row < matrix.GetLength(0)-4 && col >= 2 && col < matrix.GetLength(1) &&
                matrix[row, col] == 3 && matrix[row, col - 2] == 3 && matrix[row, col - 1] == 3 && matrix[row + 1, col] == 3 && matrix[row + 2, col - 1] == 3 && matrix[row + 2, col] == 3 && matrix[row + 3, col] == 3 && matrix[row + 4, col - 2] == 3 && matrix[row + 4, col - 1] == 3 && matrix[row + 4, col] == 3;
            return foundThree ? 3 : 0;
        }
        private static int CheckForFour(int[,] matrix, int row,int col)
        {
            bool foundFour = row >= 0 && row < matrix.GetLength(0)-4 && col >= 0 && col < matrix.GetLength(1) - 2 &&
                matrix[row, col] == 4 && matrix[row + 1, col] == 4 && matrix[row + 2, col] == 4 && matrix[row + 2, col + 1] == 4 && matrix[row, col + 2] == 4 && matrix[row + 1, col + 2] == 4 && matrix[row + 2, col + 2] == 4 && matrix[row + 3, col + 2] == 4 && matrix[row + 4, col + 2] == 4;
            return foundFour ? 4 : 0;
        }
        private static int CheckForFive(int[,] matrix, int row,int col)
        {
            bool foundFive = row >= 0 && row < matrix.GetLength(0)-4 && col >= 0 && col < matrix.GetLength(1) - 2 &&
                matrix[row, col] == 5 && matrix[row, col + 1] == 5 && matrix[row, col + 2] == 5 && matrix[row + 1, col] == 5 && matrix[row + 2, col] == 5
                && matrix[row + 2, col + 1] == 5 && matrix[row + 2, col + 2] == 5 && matrix[row + 3, col + 2] == 5 && matrix[row + 4, col] == 5
                && matrix[row + 4, col + 1] == 5 && matrix[row + 4, col + 2] == 5;
            return foundFive ? 5 : 0;
        }
        private static int CheckForSix(int[,] matrix, int row,int col)
        {
            bool foundSix = row >= 0 && row < matrix.GetLength(0)-4 && col >= 0 && col < matrix.GetLength(1) - 2 &&
           matrix[row, col] == 6 && matrix[row, col + 1] == 6 && matrix[row, col + 2] == 6 && matrix[row + 1, col] == 6 && matrix[row + 2, col] == 6
                && matrix[row + 2, col + 1] == 6 && matrix[row + 2, col + 2] == 6 && matrix[row + 3, col] == 6 && matrix[row + 3, col + 2] == 6 && matrix[row + 4, col] == 6
                && matrix[row + 4, col + 1] == 6 && matrix[row + 4, col + 2] == 6;
            return foundSix ? 6 : 0;
            
        }

        private static int CheckForSeven(int[,] matrix, int row, int col)
        {
            bool foundSeven = row >= 0 && row < matrix.GetLength(0)-4 && col >= 2 && col < matrix.GetLength(1) && matrix[row, col] == 7 && matrix[row, col - 2] == 7 && matrix[row, col - 1] == 7 && matrix[row + 1, col] == 7 &&
                matrix[row + 2, col - 1] == 7 && matrix[row + 3, col - 1] == 7 && matrix[row + 4, col - 1] == 7;
            return foundSeven ? 7 : 0;
        }
        private static int CheckForEight(int[,] matrix, int row, int col)
        {
            bool foundEight = row >= 0 && row < matrix.GetLength(0)-4 && col >= 0 && col < matrix.GetLength(1) - 2 && matrix[row, col] == 8 && matrix[row, col + 2] == 8 && matrix[row, col + 1] == 8 && matrix[row + 1, col] == 8 &&
                matrix[row + 1, col + 2] == 8 && matrix[row + 2, col + 1] == 8 && matrix[row + 3, col] == 8 && matrix[row + 3, col + 2] == 8 && matrix[row + 4, col] == 8 && matrix[row + 4, col + 1] == 8 && matrix[row + 4, col + 2] == 8;
            return foundEight ? 8 : 0;
        }
        private static int CheckForNine(int[,] matrix, int row, int col)
        {
            bool foundNine = row >= 0 && row < matrix.GetLength(0)-4 && col >= 0 && col < matrix.GetLength(1) - 2 && matrix[row, col] == 9 && matrix[row, col + 2] == 9 && matrix[row, col + 1] == 9 && matrix[row + 1, col] == 9 &&
                matrix[row+1,col+2] == 9 &&matrix[row+2, col+1] == 9 &&matrix[row+2, col+2] == 9 &&matrix[row+3, col+2] == 9 &&matrix[row+4, col] == 9 &&matrix[row+4, col+1] == 9 &&matrix[row+4, col+2] == 9;
            return foundNine ? 9 : 0;
        }


    }
}
