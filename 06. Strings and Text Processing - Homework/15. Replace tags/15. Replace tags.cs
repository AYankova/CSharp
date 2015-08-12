//•	Write a program that replaces in a HTML document given as string all the tags
//  <a href="…">…</a> with corresponding tags [URL=…]…/URL].

//Example:

//   input	
//<p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>	
//   output
//<p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>

using System;

class ReplaceTags
{
    static void Main()
    {
       //Console.WriteLine("Enter the HTML document:");
       //string input = Console.ReadLine();
        string input="<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";

        while (input.Contains("<a href=\""))
        {
            input = input.Replace("<a href=\"","[URL=");
        }
        while (input.Contains("\">"))
        {
            input = input.Replace("\">","]");
        }
        while (input.Contains("</a>"))
        {
           input = input.Replace("</a>","[/URL]"); 
        }
        Console.WriteLine(input);
    }
}

