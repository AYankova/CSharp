//•	Write a program that extracts from given HTML file its title (if available), 
//  and its body text without the HTML tags.

using System;
using System.Text;

class ExtractTextFromHTML
{
    static void Main()
    {
        //Console.WriteLine("Enter the text here:");
        //string input = Console.ReadLine();
        string input = "<html><head><title>News</title></head><body><p><a href=\"http://academy.telerik.com\">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.</p></body></html>";

        if (input.Contains("<title>"))
        {
            int indexOpenTitle = input.IndexOf("<title>");
            int indexCloseTitle = input.IndexOf("</title>");

            Console.WriteLine("Title: " + input.Substring(indexOpenTitle + 7, indexCloseTitle - indexOpenTitle - 7));
            input = input.Substring(indexCloseTitle+8);
        }

        if (input.Contains("</a>"))
        {
            input = input.Replace("</a>","</a> ");
        }

        StringBuilder sb = new StringBuilder();
        sb.Append(input);

        while (sb.ToString().Contains("<") || sb.ToString().Contains(">"))
        {
            int start = sb.ToString().IndexOf("<");
            int end = sb.ToString().IndexOf(">");
            sb.Remove(start, end - start +1);
        }

        Console.WriteLine("Text: "+sb.ToString().Trim());

    }
}

