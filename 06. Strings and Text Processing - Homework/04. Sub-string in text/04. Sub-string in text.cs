//• Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
//Example:

//The target sub-string is in

//The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very 
//tight. So we are drinking all the day. We will move out of it in 5 days.

//The result is: 9

using System;

class SubStringInText
{
    static void Main()
    {
        //Console.Write("Enter some text: ");
        //string text = Console.ReadLine();
        string text = "We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

       // Console.Write("Enter substring to search for: ");
       //string subs = Console.ReadLine();
        string subs="in";

        int count = 0;
        int index = text.IndexOf(subs, 0,StringComparison.OrdinalIgnoreCase);

        while (index!=-1)
        {
            count++;
            index++;
            index=text.IndexOf(subs, index,StringComparison.OrdinalIgnoreCase);
        }

        Console.WriteLine("The result is: "+count);
    }
}

