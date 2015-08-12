//Write a program that prints an isosceles triangle of 9 copyright symbols
using System;
using System.Text;

namespace Triangle
{
    class Triangle
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            char varSymbol = '\u00a9';

            Console.WriteLine(new string(' ', 3) + varSymbol + new string(' ', 3));
            Console.WriteLine();
            Console.WriteLine(new string(' ', 2) + varSymbol + new string(' ', 1) + varSymbol + new string(' ', 2));
            Console.WriteLine();
            Console.WriteLine(new string(' ', 1) + varSymbol + new string(' ', 3) + varSymbol + new string(' ', 1));
            Console.WriteLine();
            Console.WriteLine("{0} {0} {0} {0}", varSymbol);
            
        }
    }
}
