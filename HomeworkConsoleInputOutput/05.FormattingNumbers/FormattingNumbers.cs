/*Write a program that reads 3 numbers:
integer a (0 <= a <= 500)
floating-point b
floating-point c
The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
The number a should be printed in hexadecimal, left aligned
Then the number a should be printed in binary form, padded with zeroes
The number b should be printed with 2 digits after the decimal point, right aligned
The number c should be printed with 3 digits after the decimal point, left aligned.*/

using System;
using System.Globalization;
using System.Threading;

namespace FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Write("Please enter the integer number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Please enter first floating-point number: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter second floating-point number: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("|{0}|{1}|{2,10:F2}|{3,-10:F3}", 
                              Convert.ToString(a, 16).ToUpper().PadRight(10), Convert.ToString(a, 2).PadLeft(10, '0'), b, c);

        }
    }
}
