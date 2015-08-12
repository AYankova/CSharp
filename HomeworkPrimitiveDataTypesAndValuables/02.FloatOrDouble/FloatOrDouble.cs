/*Which of the following values can be assigned to a variable of type float and which to a variable of type double: 
34.567839023, 12.345, 8923.1234857, 3456.091?
Write a program to assign the numbers in variables and print them to ensure no precision is lost.*/

using System;

namespace FloatOrDouble
{
    class FloatOrDouble
    {
        static void Main()
        {
            double firstNum = 34.567839023;
            float secondNum=12.345f;
            double thirdNum = 8923.123485;
            float fourthNum=3456.091f;
            Console.WriteLine("First Number is double: " + firstNum + "\nSecond number is float: " + secondNum +
                "\nThird number is double: " + thirdNum + "\nFourth number is float: " + fourthNum);

        }
    }
}
