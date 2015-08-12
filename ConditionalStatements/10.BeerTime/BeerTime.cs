/*A beer time is after 1:00 PM and before 3:00 AM.
Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM 
designator) and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed.*/

using System;
using System.Globalization;

namespace BeerTime
{
    class BeerTime
    {
        static void Main()
        {
            CultureInfo formatProvider = CultureInfo.InvariantCulture;
            Console.WriteLine("Please enter time in format hh:mm tt ");
            DateTime inputTime = DateTime.Parse(Console.ReadLine());
            String.Format("{0:t}",inputTime);
            DateTime afterPm = DateTime.ParseExact("01:00 PM", "hh:mm tt", formatProvider);
            DateTime beforeAm = DateTime.ParseExact("03:00 AM", "hh:mm tt", formatProvider);
            if (((inputTime.TimeOfDay.CompareTo(afterPm.TimeOfDay)>=0) || (inputTime.TimeOfDay.CompareTo(beforeAm.TimeOfDay) < 0)))
            {
                Console.WriteLine("beer time"); 
            }
            else 
            {
                Console.WriteLine("non-beer time");
            }
        }


 
    }
}
