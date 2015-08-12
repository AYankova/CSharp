//•	Write a program that reads two dates in the format:
//  day.month.year and calculates the number of days between them.

//Example:

//Enter the first date: 27.02.2006
//Enter the second date: 3.03.2006
//Distance: 4 day

using System;
using System.Globalization;

class DateDifference
{
    static void Main()
    {
        string format = "d.M.yyyy";
        try
        {
            Console.WriteLine("Enter first date in format dd.MM.yyyy:");
            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), format, CultureInfo.InvariantCulture);
            Console.WriteLine("Enter second date in format dd.MM.yyyy:");
            DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), format, CultureInfo.InvariantCulture);

            Console.WriteLine("The days between {0:dd.MM.yyyy} and {1:dd.MM.yyyy} are {2}", firstDate<secondDate?firstDate:secondDate, secondDate>firstDate? secondDate:firstDate, 
                firstDate<secondDate?(secondDate - firstDate).TotalDays:(firstDate-secondDate).TotalDays);
        }
        catch (FormatException)
        {
            Console.WriteLine("Unrecognized format!");
        }
    }
}

