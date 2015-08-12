//•	Write a program that reads a text file containing a list of strings, sorts them
//  and saves them to another text file.

using System;
using System.IO;
using System.Collections.Generic;

class SaveSortedNames
{
    static void Main()
    {
        string fileName = @"..\..\names.txt" ;

        string sortedName = @"..\..\sortedNames.txt";

        StreamReader reader = new StreamReader(fileName);

        List<string> names = new List<string>();


        using (reader)
        {
            string name = reader.ReadLine();

            while (name != null)
            {
                names.Add(name);

                name = reader.ReadLine();
            }
        }

        names.Sort();

        StreamWriter writer = new StreamWriter(sortedName, true);

        using (writer)
        {
            for (int i = 0; i < names.Count; i++)
            {
                writer.WriteLine(names[i]);
            }
        }
        Console.WriteLine("Success!");
        Console.WriteLine("You can find the file in "+Path.GetFullPath("sortedName.txt"));
    }
}


