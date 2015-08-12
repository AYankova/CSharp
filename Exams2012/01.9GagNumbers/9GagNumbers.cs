using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace _01._9GagNumbers
{
    class Program
    {
        static void Main()
        {
            string[] alpha = { "-!", "**", "!!!", "&&", "&-", "!-", "*!!!", "&*!", "!!**!-" };

            var input = Console.ReadLine();

            var currLetter = new StringBuilder();
            BigInteger result = 0;
            foreach (var c in input)
            {
                currLetter.Append(c);
                if (alpha.Contains(currLetter.ToString()))
                {
                    int currDigit = Array.IndexOf(alpha, currLetter.ToString());
                    result *= 9;
                    result += currDigit;
                    currLetter.Clear();
                }
            }

            Console.WriteLine(result);
        }
    }
}
