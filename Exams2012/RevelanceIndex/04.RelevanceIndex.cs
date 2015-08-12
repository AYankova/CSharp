using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RelevanceIndex
{
    static void Main()
    {
        char[] separators = new char[] { ',', '.', '(', ')', ';', '-', '!', '?' };
        string target = Console.ReadLine().ToLower();
        int lines = int.Parse(Console.ReadLine());
        string[] paragraphs = new string[lines];
        for (int i = 0; i < lines; i++)
        {
            paragraphs[i] = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            sb.Append(paragraphs[i]);
            for (int j = 0; j < sb.Length; j++)
            {
                if (separators.Contains(sb[j]))
                {
                    sb.Replace(sb[j], ' ');
                }
            }
            paragraphs[i] = sb.ToString();
        }
        int[] count=new int[lines];
        for (int i = 0; i < paragraphs.Length; i++)
        {
            string[] temp = paragraphs[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int counter = 0;
            foreach (var word in temp)
            {
                if (word.ToLower()==target)
                {
                    count[i]++;
                    temp[counter] = word.ToUpper();
                }
                counter++;
            }
            paragraphs[i] = string.Join(" ", temp).Trim();
        }
        
        int[] sorted = new int[count.Length];
        string[] sortedPar = new string[paragraphs.Length];

        //sorted paragraphs descending
        for (int i = 0; i < count.Length; i++)
        {
            int tempIndex = Array.IndexOf(count, count.Min());
            sorted[i] = count[tempIndex];
            sortedPar[i] = paragraphs[tempIndex];
            count[tempIndex] = Int32.MaxValue;

        }
        //output ascending
        for (int i = sortedPar.Length-1; i >=0 ; i--)
        {
            Console.WriteLine(sortedPar[i].TrimEnd());
        }


        
    }
}

