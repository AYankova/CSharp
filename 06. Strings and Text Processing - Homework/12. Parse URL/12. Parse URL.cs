/*•	Write a program that parses an URL address given in the format:
  * [protocol]://[server]/[resource] and extracts from it the [protocol],
  * [server] and [resource] elements.*/

//Example:

//URL	                                                                    Information
//http://telerikacademy.com/Courses/Courses/Details/212	                    [protocol] = http 
//                                                                          [server] = telerikacademy.com 
//                                                                          [resource] = /Courses/Courses/Details/212

using System;

class ParseURL
{
    static void Main()
    {
        Console.WriteLine("Enter URL: ");
        string urlAdress = Console.ReadLine();
        //string urlAddres="http://telerikacademy.com/Courses/Courses/Details/212";

        int index1 = urlAdress.IndexOf(":");
        int index2 = urlAdress.IndexOf("/");
        int index3 = urlAdress.IndexOf("/",index2+2);

        Console.WriteLine("[protocol]={0}",urlAdress.Substring(0,index1));
        Console.WriteLine("[server]={0}",urlAdress.Substring(index2+2,index3-index2-2));
        Console.WriteLine("[resource]={0}",urlAdress.Substring(index3,urlAdress.Length-index3));

    }
}
