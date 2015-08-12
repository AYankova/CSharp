//•	Write a program that concatenates two text files into another text file.

using System;
using System.IO;
using System.Text;

class ConcatenateTextFiles
{
    static void MakeTestFile(string file)
    {
        StreamWriter writer = null;
        try
        {
            writer = new StreamWriter(file + ".txt");
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        using (writer)
        {
            for (int i = 1; i <= 10; i++)
            writer.WriteLine(i);
        }
    }
    static void Main()
    {
        try
        {
            MakeTestFile("test1");
            MakeTestFile("test2");

            StreamReader reader1 = new StreamReader("test1.txt"); 
            StreamReader reader2 = new StreamReader("test1.txt");

            string readFirst = string.Empty;
            string readSecond = string.Empty;

            using (reader1)
            {
                readFirst = reader1.ReadToEnd();
            }

            using (reader2)
            {
                readSecond = reader2.ReadToEnd();
            }

            StreamWriter writer = new StreamWriter("result.txt");
            using (writer)
            {
                writer.WriteLine(readFirst);
                writer.WriteLine(readSecond);
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("Task complete. Created file result.txt.");
        Console.WriteLine("You can find the file in "+Path.GetFullPath("result.txt"));
    }
}
