//Write a program that reads 3 real numbers from the console and prints their sum.

using System;

namespace SumOfThreeNumbers
{
    class SumOf3Numbers
    {
        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            Console.Write("Please input first number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please input second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please input third number: ");
            double number3 = Convert.ToDouble(Console.ReadLine());
            double sum = number1 + number2 + number3;
            Console.WriteLine("The sum is: "+sum);
        }
    }
}
