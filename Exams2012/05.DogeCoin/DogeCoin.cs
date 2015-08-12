using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DogeCoin
{
    static void Main()
    {
        string[] dimensions = Console.ReadLine().Split(' ');
        int n = int.Parse(dimensions[0]);
        int m = int.Parse(dimensions[1]);
        int[,] coins = new int[n, m];
        int lines = int.Parse(Console.ReadLine());

        for (int i = 0; i < lines; i++)
        {
            string[] currentCoords = Console.ReadLine().Split();
            int x = int.Parse(currentCoords[0]);
            int y = int.Parse(currentCoords[1]);
            coins[x, y]++;
        }

        int[,] dp = new int[n, m];
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                int coinAbove = 0;
                int coinLeft = 0;
                if (row>=1)
                {
                    coinAbove = dp[row - 1, col];
                }
                if (col>=1)
                {
                    coinLeft = dp[row, col - 1];
                }
                dp[row, col] = Math.Max(coinLeft, coinAbove) + coins[row, col];
            }
        }
        Console.WriteLine(dp[n-1,m-1]);
    }
}

