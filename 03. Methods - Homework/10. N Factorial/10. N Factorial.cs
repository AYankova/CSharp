//Write a program to calculate n! for each n in the range [1..100].
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.

using System;
using System.Collections.Generic;

class NFactorial
{
    private static List<int> MultuplyNumAsArr(List<int> temp,int n)
    {
        List<int> res=new List<int>();
        for (int i = 0; i < temp.Count; i++)
        {
            res.Add(temp[i] * n);
        }
        for (int j = 1; j < temp.Count; j++)
        {
            if (res[j - 1] > 9)
            {
                res[j] +=res[j - 1] / 10;
                res[j - 1] %= 10;         
            }
        }
        int len= res.Count - 1;
        while (res[len] > 9)
        {
            res.Add(res[len] / 10);        
            res[len]%= 10;
            len++;
        }
    return res;
    }

    static void Main()
    {
        Console.Write("Enter n to calculate its factorial: ");
        int n = int.Parse(Console.ReadLine());
        if (n < 1 || n > 100)
        {
            throw new ArgumentOutOfRangeException("range must be positive and less than 100");
        }
        else
        {
            List<int> res = new List<int>();
            res.Add(1);
            for (int i = 2; i <= n; i++)
            {
                List<int> newRes = MultuplyNumAsArr(res, i);
                res = newRes;
            }
            Console.Write("{0}!= ", n);
            for (int i = res.Count - 1; i >= 0; i--)
            {
                Console.Write(res[i]);
            }
            Console.WriteLine();
        }
    }
}
