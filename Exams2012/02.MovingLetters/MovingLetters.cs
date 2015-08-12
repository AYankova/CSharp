using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MovingLetters
{
    static void Main()
    {
        string[] words = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        StringBuilder sb = new StringBuilder();

        string max = words[0];
        int index=0;
        for (int i = 1; i < words.Length; i++)
        {
            if (max.Length < words[i].Length)
            {
                max = words[i];
                index = i;
            }
        }
        
       while (words[index] != "")
       {
       for (int i = 0; i < words.Length; i++)
       {
           
               if (words[i] != "")
               {
                   //string letter = words[i].Substring(words[i].Length - 1, 1);
                   //sb.Append(letter);
                   //words[i] = words[i].Remove(words[i].Length - 1, 1);
                   int currentLetterIndex = words[i].Length - 1 - index;
                   if (currentLetterIndex >= 0)
                   {
                       sb.Append(words[i][currentLetterIndex]);
                   }
               }
           }
           
       }
       
       for (int index1 = 0; index1 < max.Length; index1++)
        {
            for (int i = 0; i < words.Length; i++)
            {
                int currentLetterIndex = words[i].Length - 1 - index1;
                if (currentLetterIndex >= 0)
                {
                    sb.Append(words[i][currentLetterIndex]);
                }
            }
        }

        for (int i = 0; i < sb.Length; i++)
        {
            switch (sb[i])
            {
                case 'a':
                case 'A':
                    Swap(sb,1,i);break;
                case 'b':
                case 'B':
                    Swap(sb,2,i);break;
                case 'c':
                case 'C':
                    Swap(sb,3,i); break;
                case 'd':
                case 'D':
                    Swap(sb,4,i); break;
                case 'e':
                case 'E':
                    Swap(sb,5,i); break;
                case 'f':
                case 'F':
                    Swap(sb,6,i); break;
                case 'g':
                case 'G':
                    Swap(sb,7,i); break;
                case 'h':
                case 'H':
                    Swap(sb,8,i); break;
                case 'i':
                case 'I':
                    Swap(sb,9,i); break;
                case 'j':
                case 'J':
                    Swap(sb,10,i); break;
                case 'k':
                case 'K':
                    Swap(sb,11,i); break;
                case 'l':
                case 'L':
                    Swap(sb,12,i); break;
                case 'm':
                case 'M':
                    Swap(sb,13,i); break;
                case 'n':
                case 'N':
                    Swap(sb,14,i); break;
                case 'o':
                case 'O':
                    Swap(sb,15,i); break;
                case 'p':
                case 'P':
                    Swap(sb,16,i); break;
                case 'q':
                case 'Q':
                    Swap(sb,17,i); break;
                case 'r':
                case 'R':
                    Swap(sb,18,i); break;
                case 's':
                case 'S':
                    Swap(sb,19,i); break;
                case 't':
                case 'T':
                    Swap(sb,20,i); break;
                case 'u':
                case 'U':
                    Swap(sb,21,i); break;
                case 'v':
                case 'V':
                   Swap(sb,22,i); break;
                case 'w':
                case 'W':
                    Swap(sb,23,i); break;
                case 'x':
                case 'X':
                    Swap(sb,24,i); break;
                case 'y':
                case 'Y':
                    Swap(sb,25,i); break;
                case 'z':
                case 'Z':
                    Swap(sb,26,i); break;
            }
        }
        Console.WriteLine(sb);
    }
    private static void Swap(StringBuilder sb,int n,int i)
    {  
            char tmp = sb[i];
            int index = (i + n) % sb.Length;
          
            if(index==0)
            {
                for (int j = i-1; j>=0; j--)
                {
                    sb[j+1] = sb[j];
                } 
                
                      sb[index] = tmp;
            }
            else
            {
                if (index > i)
                {
                    for (int j = i + 1; j <= index; j++)
                    {

                        sb[j - 1] = sb[j];
                    }
                    sb[index] = tmp;

                }
                else
                {
                    for (int j = i-1; j>=index; j--)
                    {

                        sb[j + 1] = sb[j];
                    }
                    sb[index] = tmp;
                }
            }
    }
}

