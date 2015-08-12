/*•	Write a program that enters file name along with its full file path 
 * (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
  •	Find in MSDN how to use System.IO.File.ReadAllText(…).
  •	Be sure to catch all possible exceptions and print user-friendly error messages.*/

using System;
using System.IO;

class ReadFileContents
{
    static void Main()
    {
        //Console.WriteLine("Enter the full path of the file:");
        //string path = Console.ReadLine();
        string path = "C:\\WINDOWS\\win.ini";

        try
        {
            using (StreamReader reader = new StreamReader(path))
            {
                Console.WriteLine(File.ReadAllText(path));
            }

            Console.WriteLine("--> File's content was sucessfully read!");
        }
        catch (FileLoadException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (EndOfStreamException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (DriveNotFoundException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (ArgumentException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (PathTooLongException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (FileNotFoundException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (DirectoryNotFoundException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (IOException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (UnauthorizedAccessException exception)
        {
            Console.WriteLine(exception.Message);
        }

    }
}
