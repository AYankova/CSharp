//You are given an array of strings. Write a method that sorts the array by the length of its 
// elements (the number of characters composing them).

using System;

class SortByStringLengh
{
    static void Main()
    {
        Console.WriteLine("Enter the string array,each element separated by comma or space:");
        string input = Console.ReadLine();
        string[] strInput = input.Split(new char[]{' ','.',',','!','?','-','\'',':','(',')','{','}'}, StringSplitOptions.RemoveEmptyEntries);

        string temp = string.Empty;
        for (int i = 0; i < strInput.Length-1; i++)
        {
            for (int j = i + 1; j < strInput.Length; j++)
            {
                if (strInput[i].Length > strInput[j].Length)
                {
                    temp = strInput[i];
                    strInput[i] = strInput[j];
                    strInput[j] = temp;
                }
            }
        }
        Console.WriteLine(string.Join(", ",strInput));
    }
}


//second way
/*
Array.Sort(strInput, (a, b) => a.Length.CompareTo(b.Length));
        foreach (string s1 in strInput)
            Console.Write(s1 + " ");
        Console.WriteLine();
*/