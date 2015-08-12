using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Zerg
{
    static void Main()
    {
        Dictionary<string, int> dict = new Dictionary<string, int>()
        {
                                    {"Rawr", 0},	
                                    {"Rrrr", 1},	
                                    {"Hsst", 2},
                                    {"Ssst", 3},	
                                    {"Grrr", 4},	
                                    {"Rarr", 5},
                                    {"Mrrr", 6},
                                    {"Psst", 7},	
                                    {"Uaah", 8},	
                                    {"Uaha", 9},	
                                    {"Zzzz", 10},	
                                    {"Bauu", 11},	
                                    {"Djav", 12},	
                                    {"Myau", 13},	
                                    {"Gruh", 14},
    };
        string input = Console.ReadLine().Trim();
        long result = 0;
        int pow = 0;
        StringBuilder sb = new StringBuilder();
        sb.Append(input);
        for (int i = sb.Length-1; i >=0; i-=4)
        {
            string word = sb.ToString().Substring(i - 3, 4);
            sb.Remove(i-3,4);
            result += dict[word] * (long)Math.Pow(15, pow);
            pow++;

        }
        Console.WriteLine(result);
    }
}

