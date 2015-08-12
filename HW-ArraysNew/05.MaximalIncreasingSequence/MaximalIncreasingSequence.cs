//Write a program that finds the maximal increasing sequence in an array.

//           Example:

//           input	                                            result
//           3,2,3,4,2,2,4	                                    2, 3, 4
using System;

namespace MaximalIncreasingSequence
{
    class MaximalIncreasingSequence
    {
        static void Main()
        {
            Console.WriteLine("Enter the sequence of numbers, separated by comma or space:");
            string input = Console.ReadLine();
            string[] arrInput = input.Split(',', ' ');
            int[] numbers = new int[arrInput.Length];

            for (int index = 0; index < numbers.Length; index++)
            {
                numbers[index] = int.Parse(arrInput[index]);
            }

            int len = 1;
            string output = "";
            string elements = numbers[0] + ", ";
            int bestLen = 1;
            

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i-1]<numbers[i])
                {
                    len++;
                    elements += numbers[i] + ", ";

                    if (bestLen < len)
                    {
                        bestLen = len;
                        output= elements; ;
                    }
                }
                else
                {
                    len = 1;
                    elements = numbers[i] + ", ";
                }
            }
            Console.WriteLine("Maximal increasing sequence:");
            Console.WriteLine(output.TrimEnd(','));
            Main();
        }
    }
}
