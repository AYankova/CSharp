using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

class BasicBasic  //php variables2.0
{
    static void Main()
    {
        var input = ReadInputData();

        var noComments = StripComments(input);

        MatchCollection matches = Regex.Matches(noComments, @"\b(?<=\$)(?<!\\\$)(\w+)\b");

        var sorted = matches
            .Cast<Match>()
            .Select(m => m.Value)
            .Distinct()
            .ToArray();
        Array.Sort(sorted, StringComparer.Ordinal);

        Console.WriteLine(sorted.Count());
        foreach (var item in sorted)
        {
            Console.WriteLine(item);
        }
    }

    private static string StripComments(string code)
    {
        const string re = @"(@(?:""[^""]*"")+|""(?:[^""\n\\]+|\\.)*""|'(?:[^'\n\\]+|\\.)*')|//.*|/\*(?s:.*?)\*/|# .*";
        return Regex.Replace(code, re, "$1");
    }

    private static string ReadInputData()
    {
        var line = Console.ReadLine();
        var result = new StringBuilder();
        while (true)
        {
            result.AppendLine(line);
            if (line == "?>") break;
            line = Console.ReadLine();
        }

        return result.ToString();
    }
}