//Write a method that reverses the digits of given decimal number.

using System;

class ReverseNumber
{
    static int number;

    private static int ReverseNum(int number)
    {
        string result = string.Empty;
        number = Math.Abs(number);
        while (number > 0)
        {
            int digit = number % 10;
            number = number / 10;
            result += digit;
        }
       
        return int.Parse(result);
    }
    static void Main()
    {
        Console.Write("Enter number:");
        number = int.Parse(Console.ReadLine());
        if (number<0)
        {
            Console.WriteLine("-"+ReverseNum(number));  
        }
        else
	    {
            Console.WriteLine(ReverseNum(number));
	    }
        
    }
}

