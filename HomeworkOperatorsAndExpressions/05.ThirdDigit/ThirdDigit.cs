//Write an expression that checks for given integer if its third digit from right-to-left is 7

using System;

namespace ThirdDigit
{
    class ThirdDigit
    {
        static void Main()
        {
            Console.WriteLine("Write an integer:");
            int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            bool isEqualtoSeven=(((number/100)%10)==7);
            if (isEqualtoSeven) Console.WriteLine("True -->Third digit is 7");
            else Console.WriteLine("False -->Third digit is different from 7");

        }
    }
}
