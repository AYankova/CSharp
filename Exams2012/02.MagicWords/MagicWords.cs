using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MagicWords
{
    static void Reorder(List<string> words)
    {
        //for (int i = 0; i < lst.Count; i++)
        //{
        //  int index=lst[i].Length%(lst.Count+1);
        //  if (index > i)
        //  {
        //      lst.Insert(index, lst[i]);
        //      lst.Remove(lst[i]);
        //  }
        //  else if(index<i)
        //  {
        //     string tmp = lst[i];
        //      lst.Remove(lst[i]);
        //      lst.Insert(index, tmp);
        //  }
        //  else
        //  {
        //      continue;
        //  }
        //    
        //}

        for (int pos = 0; pos < words.Count; pos++)
        {
            string word = words[pos];
            int newPos = words[pos].Length % (words.Count + 1);
            words[pos] = null; // Mark the word for deleting
            words.Insert(newPos, word);
            words.Remove(null);
        }
    }
    static StringBuilder Print(List<string> lst)
    {
        string maxWord = lst[0];
        int index = 0;
        StringBuilder sb = new StringBuilder();
        for (int i = 1; i < lst.Count; i++)
        {
            if (maxWord.Length<lst[i].Length)
            {
                maxWord = lst[i];
                index = i;
            }
        }
        for (int i = 0; i < maxWord.Length; i++)
        {
            for (int j = 0; j < lst.Count; j++)
            {
                if (i<lst[j].Length)
                {
                    sb.Append(lst[j].Substring(i,1));
                }
            }
        }
        return sb;
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<string> words = new List<string>();
        for (int i = 0; i < n; i++)
        {
            words.Add(Console.ReadLine());
        }
        Reorder(words);
        StringBuilder result = Print(words);
        Console.WriteLine(result);

    }
}

