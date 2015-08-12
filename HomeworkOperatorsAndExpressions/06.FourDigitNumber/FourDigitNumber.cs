/*Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
Prints on the console the number in reversed order: dcba (in our example 1102).
Puts the last digit in the first position: dabc (in our example 1201).
Exchanges the second and the third digits: acbd (in our example 2101).
The number has always exactly 4 digits and cannot start with 0.*/

using System;

namespace FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main()
        {
            Console.Write("Enter four-digit positive integer:");
            int number = Convert.ToInt32(Console.ReadLine());
            bool checkFirstDigit = (((number / 1000) % 10) == 0);
            if (number < 0) Console.WriteLine("You must enter a positive integer!");
            else
            {
                if ((number > 0) && (checkFirstDigit)) Console.WriteLine("First digit cannot be 0!");
                else
                {
                    int a = (number / 1000) % 10;
                    int b = (number / 100) % 10;
                    int c = (number / 10) % 10;
                    int d = number % 10;
                    int sum = (a + b + c + d);
                    Console.WriteLine("The sum of the digits is: " + sum);
                    Console.WriteLine("Reverse number is " + d + c + b + a);
                    Console.WriteLine("Last number in first position: " + d + a + b + c);
                    Console.WriteLine("Exchanged the second and the third digits: " + a + c + b + d);


                }
            }
        }
    }
}
