/*Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
Print “not a digit” in case of invalid input.
Use a switch statement.*/

using System;
using System.Globalization;

namespace DigitAsWord
{
    class DigitAsWord
    {
        static void Main()
        {
           
            System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Write("Please enter an integer number between 1 and 9: ");
            string wordAsStr=Console.ReadLine();
            int number;
            bool word = Int32.TryParse(wordAsStr, out number);
            if (word)
            {

                switch (number)
                {
                    case 1:
                        Console.WriteLine("one");
                        break;
                    case 2:
                        Console.WriteLine("two");
                        break;
                    case 3:
                        Console.WriteLine("three");
                        break;
                    case 4:
                        Console.WriteLine("four");
                        break;
                    case 5:
                        Console.WriteLine("five");
                        break;
                    case 6:
                        Console.WriteLine("six");
                        break;
                    case 7:
                        Console.WriteLine("seven");
                        break;
                    case 8:
                        Console.WriteLine("eight");
                        break;
                    case 9:
                        Console.WriteLine("nine");
                        break;
                    default:
                        Console.WriteLine("Not a digit");
                        break;
                }
            }
            else Console.WriteLine("Not a digit");

        }
    }
}
