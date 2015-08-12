using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace _02.Crossword
{
    class Crossword
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<string> words=new List<string>();
            char[,] crossword=new char[n,n];
            for (int i = 0; i < 2*n; i++)
            {
                words.Add(Console.ReadLine());
            }
            words.Sort();
            char[] letters = words.ToString().ToCharArray();

            for (int row = 0; row < crossword.GetLength(0); row++)
            {
                for (int col = 0; col < crossword.GetLength(1); col++)
                {
                    for (int i = 0; i < n; i++)
                    {
                        crossword[row, col] = letters[i];
                        if (words.IndexOf(letters[0])!=-1)
                        {
                            
                        }
                    }
                }
                
            }
        }
    }
}
