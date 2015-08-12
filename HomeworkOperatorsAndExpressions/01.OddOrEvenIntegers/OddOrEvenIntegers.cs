//Write an expression that checks if given integer is odd or even

using System;

namespace OddOrEvenIntegers
{
    class OddOrEvenIntegers
    {
        static void Main()
        {
            Console.WriteLine("Insert some integer number:");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0) Console.WriteLine("The number is even");
            else Console.WriteLine("Numbver is odd");
        }
    }
}
