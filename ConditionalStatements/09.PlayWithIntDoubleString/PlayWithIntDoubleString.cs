/*Write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement.*/

using System;

namespace PlayWithIntDoubleString
{
    class PlayWithIntDoubleString
    {
        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            Console.Write("Enter I for integer, D for double or S for string: ");
            char input = Convert.ToChar(Console.ReadLine());
            switch (input)
            {
                case 'I':
                    Console.Write("Please enter an integer number: ");
                    int intNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine(intNumber+1);
                    break;
                case 'D':
                    Console.Write("Please enter a double number: ");
                    double doubNum = double.Parse(Console.ReadLine());
                    Console.WriteLine(doubNum + 1);
                    break;
                case 'S':
                    Console.Write("Please enter a string: ");
                    string strExp = Console.ReadLine();
                    Console.WriteLine(strExp + "*");
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
                

                
            }
        }
    }
}
