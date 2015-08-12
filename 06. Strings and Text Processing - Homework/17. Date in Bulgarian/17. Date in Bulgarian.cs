/*•	Write a program that reads a date and time given in the format:
  * day.month.year hour:minute:second and prints the date and time 
  * after 6 hours and 30 minutes (in the same format) along with the 
  * day of week in Bulgarian.*/

using System;
using System.Globalization;
using System.Threading;

class DateInBulgarian
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
        CultureInfo culture = CultureInfo.GetCultureInfo("BG-bg");
        string format = "d.M.yyyy H:m:s";

        try
        {
            Console.WriteLine("Enter a date in the format day.month.year hour:minute:second ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), format, culture);
            date = date.AddHours(6.5);
            Console.WriteLine(date.ToString("dd.MM.yyyy HH:mm:ss dddd"));
        }
        catch(FormatException)
        {
            Console.WriteLine("Unrecognized format!");
        }
    }
}
