/*•	Write a program that compares two text files line by line and prints the number of
 *  lines that are the same and the number of lines that are different.
  •	Assume the files have equal number of lines.*/

using System;
using System.IO;

class CompareTextFiles
{
    static void Main()
    {
        string firstFile = @"..\..\..\03. Line numbers\03. Line numbers.cs";
        string secondFile = @"..\..\04. Compare text files.cs";

        int sameLines = 0;
        int differentLines = 0;

        try
        {
            StreamReader reader1 = new StreamReader(firstFile);
            StreamReader reader2 = new StreamReader(secondFile);

            using (reader1)
            {
                using (reader2)
                {
                    string firstFileLine=reader1.ReadLine();
                    string secondFileLine=reader2.ReadLine();

                    while (firstFileLine!=null&&secondFileLine!=null)
                    {
                        if (firstFileLine==secondFileLine)
                        {
                            ++sameLines;
                        }
                        else
                        {
                            ++differentLines;
                        }
                        firstFileLine = reader1.ReadLine();
                        secondFileLine = reader2.ReadLine();
                    }
                    Console.WriteLine("Same lines are {0} and different lines are {1}",sameLines,differentLines);
                } 
            }
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FileLoadException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (EndOfStreamException ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}

