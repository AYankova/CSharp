//Write a program that finds the biggest of three numbers.

using System;

namespace TheBiggestOf3Numbers
{
    class TheBiggestOf3Numbers
    {
        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            Console.Write("Please enter first number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Please enter second number: ");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.Write("Please enter third number: ");
            double thirdNumber = double.Parse(Console.ReadLine());
            if (firstNumber > secondNumber)
            {
                if (firstNumber > thirdNumber)
                {
                    Console.WriteLine("Greater is " + firstNumber);
                }
                else
                {
                    Console.WriteLine("Greater is " + thirdNumber);
                }
            }
            else
            {
                if (secondNumber < thirdNumber)
                {
                    Console.WriteLine("Greater is " + thirdNumber);
                }
                else
                {
                    Console.WriteLine("Greater is " + secondNumber);
                }
            }

        }


    }
}

