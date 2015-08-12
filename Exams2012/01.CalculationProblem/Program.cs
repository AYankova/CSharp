using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        Dictionary<char, int> catsLetters = new Dictionary<char, int>
            { {'a',0}, {'b',1}, {'c',2}, {'d',3}, {'e',4}, {'f',5}, {'g',6},{ 'h',7}, {'i',8}, {'j',9},{ 'k',10},{ 'l',11}, {'m',12},{ 'n', 13},{'o',14},{ 'p',15},{ 'q',16},{ 'r',17},{ 's',18},{'t',19},{'u',20},{'v',21},{'w',22}
    };
        string[] inputCat = Console.ReadLine().Split(' ');
        ulong result = 0;
        StringBuilder output = new StringBuilder();
        for (int i = 0; i < inputCat.Length; i++)
        {
            int pow = 0;
            for (int j = inputCat[i].Length - 1; j >= 0; j--)
            {
                result += (ulong)catsLetters[inputCat[i][j]] * (ulong)Math.Pow(23, pow);
                pow++;
            }
        }
        ulong temp = result;
        ulong decRep = 0;
        while (temp > 0)
        {
            ulong digit = temp % 23;
            temp /= 23;
            output.Insert(0, (char)(digit+97));
        } 
        Console.WriteLine(output+ " = "+result);
    }
}

