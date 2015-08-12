//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number,
//the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.

using System;

namespace _03.MinMaxSumAverageOfNNumbers
{
    class MinMaxSumAverageOfNNumbers
    {
        static void Main()
        {
            Console.Write("Please enter tne number of integers: ");
            int numbers = Int32.Parse(Console.ReadLine());
            int sum = 0;
            int maxValue = int.MinValue;
            int minValue = int.MaxValue;

            for (int i = 1; i <= numbers; i++)
            {
                
                Console.Write("Please enter integer {0}:", i);
                int num = Int32.Parse(Console.ReadLine());
                sum += num;
                minValue = Math.Min(minValue, num);
                maxValue = Math.Max(maxValue, num);

            }
            double average = (double)sum / numbers;
            Console.WriteLine("Min=" + minValue + "\nMax=" + maxValue + "\nSum=" + sum + "\nAverage={0:F2}", average);


        }
    }
}
