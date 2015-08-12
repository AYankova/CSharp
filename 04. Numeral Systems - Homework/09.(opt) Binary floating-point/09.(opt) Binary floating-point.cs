//Write a program that shows the internal binary representation of given 32-bit signed 
//floating-point number in IEEE 754 format (the C# type float).

using System;
using System.Text;

class BinaryFloatingPoint
{
    static void Main()
    {
        float input;
        StringBuilder result = new StringBuilder();
        Console.Write("Enter some folating point number: ");
        bool isFloat = float.TryParse(Console.ReadLine(), out input);

        if (!isFloat)
        {
        throw new FormatException("incorrect input");
        }

        byte[] digits = BitConverter.GetBytes(input);
        result.Clear();
        for (int i = 3; i >= 0; i--)
        result.Append(Convert.ToString(digits[i], 2).PadLeft(8, '0'));

        Console.WriteLine("Result: "+result);
        Console.WriteLine("Sign: "+result[0]);
        Console.WriteLine("Exponent: "+result.ToString(1, 8));
        Console.WriteLine("Mantisaa: "+result.ToString(9, result.Length - 9));
        }
    }


