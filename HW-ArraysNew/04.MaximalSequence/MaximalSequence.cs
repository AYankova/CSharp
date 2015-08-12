//Write a program that finds the maximal sequence of equal elements in an array.

//                 Example:

//                 input	                     result
//                 2,1,1,2,3,3,2,2,2,1	         2, 2, 2
using System;

namespace MaximalSequence
{
    class MaximalSequence
    {
        static void Main()
        {
            Console.WriteLine("Enter the sequence of numbers, separated by comma or space:");
            string input = Console.ReadLine();
            string[] arrInput = input.Split(new char[]{',', ' '},StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = new int[arrInput.Length];

            for (int index = 0; index < numbers.Length; index++)
            {
                numbers[index] = int.Parse(arrInput[index]);
            }

            
            int len = 1;
            int curElement = numbers[0];
            int bestLen = 1;
            int bestElement = curElement;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (curElement==numbers[i]) 
                {
                    len++;
                
                }
                else
                {
                    curElement = numbers[i];
                    len = 1;
                }
                if (bestLen < len)
                {
                    bestLen = len;
                    bestElement = curElement;
                }
            }

            Console.WriteLine("The sequence with best length is:");
            for (int j = 0; j <bestLen; j++)
            {
                Console.Write(j != bestLen - 1 ? bestElement + ", " :bestElement + "\n");
            }

            Main();
        }
    }
}