//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;
using _15.BitsExchange;

namespace BitsExchange
{
    class BitsExchange
    {
        static void Main()
        {

            Console.WriteLine("Please insert an integer number:");
            //int number = Convert.ToInt32(Console.ReadLine());
            string input=Console.ReadLine();
            string[] strArray= input.Split();
            int[] intArray=new int[strArray.Length];
            for (int i = strArray.Length; i >=0 ; i--)
            {
                intArray[i] = int.Parse(strArray[i]);
                if((i == (strArray.Length - 4)) || (i == (strArray.Length - 5)) || (i == (strArray.Length - 6))) ;
               // int p=intArray[i+21];
                int p=intArray[i];
                p = intArray[i-25];
                intArray[i -25] = intArray[i];

            }
            Console.WriteLine();
        }
    }
}
