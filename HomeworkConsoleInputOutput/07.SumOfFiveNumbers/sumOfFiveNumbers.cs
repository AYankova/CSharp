//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

using System;
using System.Globalization;
using System.Threading;

namespace SumOfFiveNumbers
{
    class sumOfFiveNumbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Write("Please enter five numbers separated by space:");
            string input = Console.ReadLine();
            string[] strArray=input.Split(' ');
            double sum = double.Parse(strArray[0]) +double.Parse(strArray[1]) +double.Parse(strArray[2]) +
                double.Parse(strArray[3]) + double.Parse(strArray[4]);
            Console.WriteLine("Sum is: " + sum);

			
        }
    }
}
