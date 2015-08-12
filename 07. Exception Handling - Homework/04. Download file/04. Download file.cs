/*•	Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
  •	Find in Google how to download files in C#.
  •	Be sure to catch all exceptions and to free any used resources in the finally block.*/

using System;
using System.IO;
using System.Net;

class DownloadFile
{
    static void Main()
    {
        string URL = "http://36.media.tumblr.com/ac75500b7cff44ecd1f57ba544590563/tumblr_naynjaI5wf1sgb8hfo1_500.jpg";
        string fileName = Path.GetFileName(URL);
        try
        {
            using (WebClient myWebClient = new WebClient())
            {
                myWebClient.DownloadFile(URL, fileName);
            }
            Console.WriteLine("Downloaded successfully!");
            Console.WriteLine("The picture is saved at {0}.", Directory.GetCurrentDirectory());

        }
        catch (UnauthorizedAccessException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (NotSupportedException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (WebException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (ArgumentException exception)
        {
            Console.WriteLine(exception.Message);
        }
    }
}

