/*•	Write a program that extracts from a given text all dates that match the 
  * format DD.MM.YYYY.
  • Display them in the standard date format for Canada.*/

using System;
using System.Globalization;
using System.Threading;

    class DatesFromTextInCanada
    {
        static void Main()
        {
            //Console.WriteLine("Enter the text:");
            //string input = Console.ReadLine();
            string input = "I was born at 28.02.1990. My best friend was born at 27.2.1992. She graduated in 5/10/2010.";
            string[] words = input.Split(' ');
            string format = "d.M.yyyy";
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");

            for (int i = 0; i < words.Length; i++)
            {
                try
                {
                    DateTime dates = DateTime.ParseExact(words[i].TrimEnd(new char[] { ',', '.', '!', '?' }), format, CultureInfo.InvariantCulture);
                    Console.WriteLine(dates.Date.ToShortDateString());
                }
                catch (FormatException)
                {
                    continue;
                }
            }
        }
    }

