//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

using System;

namespace _10.OddOrEvenProduct
{
    class OddOrEvenProduct
    {
        static void Main()
        {
            Console.Write("Please enter n numbers separated by a space: ");
            string numbers = Console.ReadLine();
            string [] numbersStr=numbers.Split(' ');
            int[] numbersInt=new int[numbersStr.Length];
            bool isOdd = true;
            int productOdds = 1;
            int productEvens = 1;
            for (int i = 0; i <numbersStr.Length; i++)
            {
                numbersInt[i] = int.Parse(numbersStr[i]);
                if (isOdd)
                {
                    productOdds *= numbersInt[i];
                }
                else
                {
                    productEvens *= numbersInt[i];
                }
                isOdd = !(isOdd);
            }
            Console.WriteLine(productOdds==productEvens);

        }
    }
}
