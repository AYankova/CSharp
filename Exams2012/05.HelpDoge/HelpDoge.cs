using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class HelpDoge
{
    static void Main()
    {
        string[] dimensions = Console.ReadLine().Split(' ');
        int n = int.Parse(dimensions[0]);
        int m = int.Parse(dimensions[1]);
        BigInteger[,] matrix = new BigInteger[n, m];
        string[] food = Console.ReadLine().Split(' ');
        matrix[int.Parse(food[0]),int.Parse( food[1])] = 1;
        int enemies = int.Parse(Console.ReadLine());
        for (int i = 0; i < enemies; i++)
        {
            string[] currentEnemiesCoords = Console.ReadLine().Split(' ');
            matrix[int.Parse(currentEnemiesCoords[0]), int.Parse(currentEnemiesCoords[1])] = -1;
        }

        
        //int countAbove = 0;
        //int countLeft = 0;
   
        int fx=int.Parse(food[0]);
        int fy=int.Parse(food[1]);
        for (int row = 0; row <= fx; row++)
        {
            for (int col = 0; col <= fy; col++)
            {
                if (row==0&&col==0)
                {
                    matrix[row, col] = 1;
                    continue;
                }
                if (matrix[row,col]==-1)
                {
                    matrix[row, col] = 0;
                    continue;
                }

                var valueAbove = row>0? matrix[row-1,col]:0;
                var valueLeft = col>0?matrix[row,col-1]:0;
                matrix[row, col] = valueAbove + valueLeft ;
            }
        }
        Console.WriteLine(matrix[fx, fy]);
    }
}

