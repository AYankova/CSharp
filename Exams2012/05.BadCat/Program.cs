using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] lines = new string[n];
        for (int i = 0; i < n; i++)
        {
            lines[i] = (Console.ReadLine().Trim());
        }
        //int[] numbers=new int[2*n];
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < lines.Length; i++)
        {
            string[] temp = lines[i].Split(' ');
            int indexSecond = result.ToString().IndexOf(temp[3]);
            int indexFirst = result.ToString().IndexOf(temp[0]);
            if (temp[2] == "before")
            {
                if (indexSecond > 0)
                {
                    result.Insert(indexSecond, temp[0]);
                }
                else
                {
                    result.Append(temp[0]); result.Append(temp[3]);
                }
            }
            if (temp[2] == "after")
            {
                if (indexFirst > 0)
                {
                    result.Insert(indexFirst, temp[3]);
                }
                else
                {
                    result.Append(temp[3]); result.Append(temp[0]);
                }
            }
        }
        for (int i = 0; i < result.Length-1; i++)
        {
            for (int j = i+1; j < result.Length; j++)
            {
                if (result[i] == result[j])
                {
                    result.Remove(j, 1);
                    i--;
                    j--;
                }
            }
        }
        int[] digits = new int[result.Length / 2];
        StringBuilder newResult = new StringBuilder();
        for (int i = 0, j = 0; i < result.Length - 1; i += 2, j++)
        {
            digits[j] = int.Parse(result[i].ToString() + result[i + 1].ToString());

        }
        Array.Sort(digits);
        for (int i = 0; i < digits.Length; i++)
        {
            Console.Write(digits[i]);
        }
        Console.WriteLine();
    }
}
