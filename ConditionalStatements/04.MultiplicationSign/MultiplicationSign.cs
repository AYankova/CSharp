/*Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
Use a sequence of if operators.*/

using System;

namespace MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            Console.Write("Please enter first real number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Please enter second real number: ");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.Write("Please enter third real number: ");
            double thirdNumber = double.Parse(Console.ReadLine());
            double product = firstNumber * secondNumber * thirdNumber;
            if ( product< 0)
            {
                Console.WriteLine("-");
            }
            else if (product>0)
            {
                Console.WriteLine("+");
            }
            else Console.WriteLine("0");
        }
    }
}
