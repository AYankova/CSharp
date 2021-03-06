﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.TrailingZerosNew
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer N: ");
            int input = int.Parse(Console.ReadLine());
            int count = 1;
            int zeroes = 0;

            // За всяко 5 на степен count, което числото input "събира", input! има по една 0 отзад.
            // Например 5! има една 0, 10! - 2, 15! - 3, 20! - 4, 25! вече е с 6, защото съдържа 5*5^1, както и 1*5^2.
            // 50! е с 12 нули - 10*5^1 + 2*5^2; 125! е с 31 нули - 25*5^1 + 5*5^2 + 1*5^3 итн.
            // Съответно този метод изчислява броя на нулите, без изобщо да пресмята самия факториел и работи бързо с много големи числа.

            while (input / Math.Pow(5, count) >= 1)
            {
                zeroes += input / (int)(Math.Pow(5, count));
                count++;
            }
            Console.WriteLine("{0}! has {1} trailing zeroes.", input, zeroes);
        }
    }
}


