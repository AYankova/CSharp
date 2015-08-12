using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.BasicLanguage
{
    class Program
    {
        static void Main()
        {
            string[] wordsInCat = Console.ReadLine().ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < wordsInCat.Length; i++)
            {
                long pow = wordsInCat[i].Length - 1;
                long resultInCat = 0;
                foreach (var ch in wordsInCat[i])
                {
                   resultInCat += (int)(ch - 'a') * (long)Math.Pow(17, pow);
                   pow--;
                }
                StringBuilder temp = new StringBuilder();
                while(resultInCat>0)
                {
                    long digit = resultInCat % 26;
                    resultInCat /= 26;
                    temp.Insert(0,(char)digit+'a');

                }
                result.Append(temp + " ");
            }
            Console.WriteLine(result.ToString().TrimEnd());
        }
    }
}
