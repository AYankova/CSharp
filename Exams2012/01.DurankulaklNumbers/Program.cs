using System;
using System.Linq;
using System.Numerics;
using System.Text;
// C# Part 2 - 2012/2013 @ 5 Feb 2013
// 1. Durankulak Numbers
class DurankulakNumbers
{
    static void Main()
    {
        string[] alpha =
		{
			
		};

        string input = Console.ReadLine();

        var currLetter = new StringBuilder();
        BigInteger result = 0;
        foreach (var c in input)
        {
            currLetter.Append(c);
            if (alpha.Contains(currLetter.ToString()))
            {
                int currDigit = Array.IndexOf(alpha, currLetter.ToString());
                result *= 168;
                result += currDigit;
                currLetter.Clear();
            }
        }

        Console.WriteLine(result);

    }
}
