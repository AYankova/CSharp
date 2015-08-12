//•	Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;

class OddLines
{
    static void Main()
    {
        try
        {
            StreamReader reader = new StreamReader(@"..\..\01. Odd lines.cs");
            string s;
            int line = 1;
            using (reader)
            {
                do
                {
                    s = reader.ReadLine();
                    if (line%2==1)
                    {
                        Console.WriteLine("{0,2} {1}", line, s);
                    }
                    line++;
                } while (s!=null);
            }
        }
        catch (DirectoryNotFoundException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (FileNotFoundException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (FileLoadException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (EndOfStreamException exception)
        {
            Console.WriteLine(exception.Message);
        }
    }
}