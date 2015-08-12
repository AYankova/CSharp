/*Write a program that gets two numbers from the console and prints the greater of them.
Try to implement this without if statements.*/

using System;

namespace NumberComparer
{
    class NumberComparer
    {
        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            Console.Write("Please input first number:");
            double number1 = double.Parse(Console.ReadLine());
            Console.Write("Please input second number:");
            double number2 = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Max(number1,number2));
        }
    }
}
