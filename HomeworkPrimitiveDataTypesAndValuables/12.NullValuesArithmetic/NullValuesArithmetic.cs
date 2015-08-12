/*Create a program that assigns null values to an integer and to a double variable.
Try to print these variables at the console.
Try to add some number or the null literal to these variables and print the result.*/

using System;

namespace NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main()
        {
            int? intNullable = null;
            double? doubleNullable = null;
            Console.WriteLine("Integer is {0} and double is {1}",intNullable,doubleNullable);

            intNullable = 5;
            doubleNullable = 5.5;
            Console.WriteLine("Integer is {0} and double is {1}", intNullable, doubleNullable);
        }
    }
}
