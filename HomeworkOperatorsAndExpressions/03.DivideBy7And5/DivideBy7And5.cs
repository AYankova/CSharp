/*Write a Boolean expression that checks for given integer if it can be divided (without remainder) 
by 7 and 5 at the same time.*/

using System;

namespace DivideBy7And5
{
    class DivideBy7And5
    {
        static void Main()
        {
            Console.WriteLine("Please insert an integer number:");
            int a = Convert.ToInt32(Console.ReadLine());
            bool Divisible = ((a % 7 == 0) && (a % 5 == 0));
            if (Divisible) Console.WriteLine("True --> Number can be divided by 7 and 5 at the same time.");
            else Console.WriteLine("False --> Number cannot be divided by 7 and 5 at the same time!");
        }
    }
}
