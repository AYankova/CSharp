/*•	Write a program that reads an integer number and calculates and prints its square root.
  o	If the number is invalid or negative, print Invalid number.
  o	In all cases finally print Good bye.
  •	Use try-catch-finally block.*/

using System;

class SquareRoot
{
    static void Main()
    {
        Console.Write("Enter an integer number:");

        try
        {
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            Console.WriteLine(Math.Sqrt(number));
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid number!");
        }
        finally
        {
            Console.WriteLine("Good Bye!");
        }

    }
}

