/*Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort,
int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.*/

using System;

namespace DeclareVariables
{
    class DeclareVariables
    {
        static void Main()
        { 
            ushort varOne= 52130;
            sbyte varTwo = -115;
            int varThree = 4825932;
            byte varFour = 97;
            short varFive=-10000;


            Console.WriteLine("First Number is ushort: "+ varOne +"\nSecond number is sbyte: "+ varTwo + "\nThird number is int: "
                + varThree + "\nFourth number is byte: "+ varFour + "\nFifth number is short: "+ varFive);

        
        }
    }
}
