using System;
using System.Collections.Generic;
using System.Text;

class StrangelandNumbers
{
    static void Main()
    {
        Dictionary<string, int> dict = new Dictionary<string, int>
        {                           {"f",0},
                                    {"bIN",1},
                                    {"oBJEC",2},
                                    {"mNTRAVL",3},
                                    {"lPVKNQ",4},
                                    {"pNWE",5},
                                    {"hT",6},

        };
        string strangeNum = Console.ReadLine();
        long pow = 0;
        long decNumber = 0;
        StringBuilder sb = new StringBuilder();
        for (int i = strangeNum.Length - 1; i >= 0; i--)
        {
            sb.Insert(0,strangeNum[i]);
            if (dict.ContainsKey(sb.ToString()))
            {
                decNumber +=dict[sb.ToString()] *(long)Math.Pow(7,pow);
                sb.Clear();
                pow++;
            }
            
        }
        Console.WriteLine(decNumber);
    }
}
