using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01.Cat
{
    class Program
    {
        const int catBase = 17;
        const int engBase = 26;
        static void Main()
        {
            string[] wordsInCat = Console.ReadLine().ToLower().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<char,int> catsLetters = new Dictionary<char,int>
            { {'a',0}, {'b',1}, {'c',2}, {'d',3}, {'e',4}, {'f',5}, {'g',6},{ 'h',7}, {'i',8}, {'j',9},{ 'k',10},{ 'l',11}, {'m',12},{ 'n', 13},{'o',14},{ 'p',15},{ 'q',16}//,{ 'r',17},{ 's',18},{'t',19},{'u',20},{'v',21},{'w',22},{'x',23},{'y',24},{'z',25}
            };
            Dictionary<long,char> englishLetters = new Dictionary<long,char>
            { {0,'a'}, {1,'b'}, {2,'c'}, {3,'d'}, {4,'e'}, {5,'f'}, {6,'g'},{7, 'h'}, {8,'i'}, {9,'j'},{ 10,'k'},{11, 'l'}, {12,'m'},{13, 'n'},{14,'o'},{15, 'p'},{ 16,'q'},{ 17,'r'},{18, 's'},{19, 't'},{20, 'u'},{21,'v'},{22,'w'},{23,'x'},{24,'y'},{25,'z'}
            };

            StringBuilder result=new StringBuilder();

            for (int i = 0; i < wordsInCat.Length; i++)
            {
                int pow=0;
                BigInteger catResult = 0;
                for (int j =  wordsInCat[i].Length-1; j>=0; j--)
                {
                    
                    char ch = wordsInCat[i][j];
                    catResult += catsLetters[ch] * (BigInteger)Math.Pow(catBase, pow);
                    pow++;

                }
                StringBuilder temp = new StringBuilder();

                 if (catResult==0)
                {
                   result.Append(englishLetters[0]); break;
                }
                while (catResult>0)
                {
                    BigInteger lastDigit = catResult % engBase;
                    catResult /= engBase;
                    temp.Insert(0,englishLetters[(long)lastDigit]);
                }
                result.Append(temp + " ");

            }

            Console.WriteLine(result.ToString().TrimEnd());
        }
    }
}
