//Write a program that finds the most frequent number in an array.

//          Example:

//          input	                            result
//          4,1,1,4,2,3,4,4,1,2,4,9,3	        4 (5 times)

using System;

namespace _09.FrequentNumber
{
    class FrequentNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter the sequence of numbers, separated by comma or space:");
            string input = Console.ReadLine();
            string[] arrInput = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = new int[arrInput.Length];

            for (int index = 0; index < numbers.Length; index++)
            {
                numbers[index] = int.Parse(arrInput[index]);
            }

            Array.Sort(numbers);
            int counter = 1;
            int maxCounter = 1;
            int curElement = numbers[0];
            int bestElement = curElement;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] ==curElement)
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                    curElement = numbers[i];

                }

                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    bestElement = curElement;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Most frequent number:");
            Console.WriteLine(bestElement+"("+maxCounter+"times)");
            Console.WriteLine();
            Main();
        }
    }
}
