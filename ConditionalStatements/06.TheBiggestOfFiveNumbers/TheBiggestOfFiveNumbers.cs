//Write a program that finds the biggest of five numbers by using only five if statements.

using System;

namespace TheBiggestOfFiveNumbers
{
    class TheBiggestOfFiveNumbers
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
            Console.Write("Please enter fourth number: ");
            double fourthNumber = double.Parse(Console.ReadLine());
            Console.Write("Please enter fifth number: ");
            double fifthNumber = double.Parse(Console.ReadLine());
            double[] numArr = new double[5] { firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber };
            double max = numArr[0];
            for (int i = 1; i < 5; i++)
            {
                max = Math.Max(max, numArr[i]);
            }
            if (numArr[0] == max)
            {
                Console.WriteLine(numArr[0]);
            }
            else if (numArr[1] == max)
            {
                Console.WriteLine(numArr[1]);
            }
            else if (numArr[2] == max)
            {
                Console.WriteLine(numArr[2]);
            }
            else if (numArr[3] == max)
            {
                Console.WriteLine(numArr[3]);
            }
            else if (numArr[4] == max)
            {
                Console.WriteLine(numArr[4]);
            }


        }
    }
}
