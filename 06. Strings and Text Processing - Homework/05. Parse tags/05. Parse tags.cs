//•	You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and</upcase> to upper-case.
//•	The tags cannot be nested.

//Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

//The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

using System;
using System.Text;

class ParseTags
{
    static void Main()
    {
        //Console.WriteLine("Enter the text: ");
        //string text = Console.ReadLine();
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        StringBuilder newText = new StringBuilder();

        int index1 = text.IndexOf("<upcase>", 0);
        int index2 = text.IndexOf("</upcase>", 0);
        if (index1 == -1 || index2 == -1 || index1 > index2)
        {
            Console.WriteLine("Incorrect input!");
        }
        else
        {
            newText.Append(text.Substring(0, index1));

            while (index1 != -1 && index2 != -1)
            {
                newText.Append(text.Substring(index1 + "<upcase>".Length, index2 - index1 - "<upcase>".Length).ToUpper());
                index1++;  
                index1 = text.IndexOf("<upcase>", index1);
                if (index1 == -1) break;
                newText.Append(text.Substring(index2 + "</upcase>".Length, index1 - index2 - "</upcase>".Length));
                index2++;
                index2 = text.IndexOf("</upcase>", index2);
            }
            newText.Append(text.Substring(index2 + "</upcase>".Length, text.Length - index2 - "</upcase>".Length));
        }

        Console.WriteLine(newText);

    }
}

