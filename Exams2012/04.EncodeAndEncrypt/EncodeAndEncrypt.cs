using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class EncodeAndEncrypt
{
    static void Main()
    {
        string message = Console.ReadLine();
        string cypher = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        Dictionary<char, int> dict = new Dictionary<char, int>
        { {'A',0},{'B',1},{'C',2},{'D',3},{'E',4},{'F',5},{'G',6},{'H',7},{'I',8},{'J',9},{'K',10},{'L',11},{'M',12},{'N',13},{'O',14},{'P',15},{'Q',16},{'R',17},{'S',18},{'T',19},{'U',20},{'V',21},{'W',22},{'X',23},{'Y',24},{'Z',25}};
        int max = Math.Max(message.Length, cypher.Length);
        for (int i = 0; i < max; i++)
        {
            if (i<message.Length&&i<cypher.Length)
            {
              int code=dict[message[i]] ^dict[cypher[i]];
              code += 65;
                sb.Append((char)code);
            }
            else if (i<=message.Length-1&&i>cypher.Length-1)
            {
                int code = dict[message[i]] ^ dict[cypher[i%cypher.Length]];
                code += 65;
                sb.Append((char)code);
            }
            else if(i<=cypher.Length&&i>message.Length-1)
            {
                int code = dict[message[i%message.Length]] ^ dict[cypher[i]]^dict[cypher[i%message.Length]];
                code += 65;
                sb.Insert(i%message.Length,(char)code);
                sb.Remove((i % message.Length) + 1, 1);
            }
        }
       
        sb.Append(cypher);
        int counter = 1;
        for (int i = 0; i < sb.Length; i++)
        {
            char letter = sb[i];
            for (int j = i + 1; j < sb.Length; j++)
            {
                if (sb[j] == letter)
                {
                    counter++;
                    if (j==sb.Length-1&& counter>2)
                    {
                        sb.Remove(j - counter+1, counter-1);
                        sb.Insert(j - counter+1 , counter);
                    }
                }
                else
                {
                    if (counter > 2)
                    {
                        sb.Remove(j - counter, counter - 1);
                        sb.Insert(j - counter , counter);
                       
                    }
                    counter = 1;
                    break;
                }
            }
        }
        sb.Append(cypher.Length);
        Console.WriteLine(sb);
    }
}

