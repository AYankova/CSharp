/*•	Write a method ReadNumber(int start, int end) that enters an integer number in a given  range [start…end].
  o	If an invalid number or non-number text is entered, the method should throw an exception.
  •	Using this method write a program that enters 10 numbers: a1, a2, … a10, such that  1 < a1 < … < a10 < 100 */

using System;

class EnterNumbers
{
    static int ReadNumber(int start,int end) 
    {
        int number = int.Parse(Console.ReadLine());
            if (number <= start || number >= end)
                throw new ArgumentOutOfRangeException();
            return number;
    }
    static void Main()
    {
        int[] numbers = new int[10];
        Console.WriteLine("You will have to enter 10 numbers in the range (1..100) in an increasing sequence:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Enter number {0,2}:",i+1);
            try
            {
                  if (i == 0)
                        numbers[i] = ReadNumber(0, 90 + i);
                    else
                        numbers[i] = ReadNumber(numbers[i - 1], 90 + i);
            }
            catch (ArgumentOutOfRangeException argEx)
            {
                Console.WriteLine(argEx.Message);
                Console.WriteLine("Try again.");
                i--;
                continue;
            }
            catch (OverflowException overFlowEx)
            {
                Console.WriteLine(overFlowEx.Message);
                Console.WriteLine("Try again.");
                i--;
                continue;
            }
            catch(FormatException formatEx)
            {
                Console.WriteLine(formatEx.Message);
                Console.WriteLine("Try again.");
                i--;
                continue;
            }
        }

    }
}
