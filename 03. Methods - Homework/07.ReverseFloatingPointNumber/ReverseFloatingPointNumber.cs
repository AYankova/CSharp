using System;
using System.Globalization;
using System.Threading;

class ReverseFloatingPointNumber
    {
    static double number;

    private static double ReverseNum(double number)
    {
        number = Math.Abs(number);
        string num = number.ToString();
        char[] numChar=num.ToCharArray();
        Array.Reverse(numChar);
        string result = new string (numChar);
        return double.Parse(result);
    }
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Write("Enter number:");
            number = double.Parse(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("-" + ReverseNum(number));
            }
            else
            {
                Console.WriteLine(ReverseNum(number));
            }
        
        }
    }

