using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Pattern
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix=new int[n,n];
        for (int row = 0; row < n; row++)
        {
            string[] line = Console.ReadLine().Split(' ');
            for (int col = 0; col < n; col++)
            {
                matrix[row,col]=int.Parse(line[col]);
            }
        }
        int sum = int.MinValue;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (sum<PatternSum(matrix,i,j))
                {
                    sum = PatternSum(matrix, i, j);
                }
            }
        }
        if (sum == 0)
        {
            sum = matrix[0, 0];
            for (int i = 0; i < n - 1; i++)
            {
                sum += matrix[i + 1, i + 1];
            }
            Console.WriteLine("NO " + sum);
        }
        else
        {
            Console.WriteLine("YES" + " " + sum);
        }
       
    }
    private static int PatternSum(int[,]matrix,int row,int col)
    {
        bool foundPattern = row >= 0 && row < matrix.GetLength(0) - 2 && col >= 0 && col < matrix.GetLength(1) - 4 && matrix[row, col + 1] == matrix[row, col] + 1 && matrix[row, col + 2] == matrix[row, col + 1] + 1 && matrix[row + 1, col + 2] == matrix[row, col + 2] + 1 && matrix[row + 2, col + 2] == matrix[row + 1, col + 2] + 1 && matrix[row + 2, col + 3] == matrix[row + 2, col + 2] + 1 && matrix[row + 2, col + 4] == matrix[row + 2, col + 3] + 1;
        if (foundPattern)
        {
            int patternSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col + 2] + matrix[row + 2, col + 2] + matrix[row + 2, col + 3] + matrix[row + 2, col + 4];
            return patternSum;
        }
        else return 0;
    }
}

