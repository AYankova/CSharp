namespace DivisibleNumbersBy7And3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class DivisibleNumbersBy7And3
    {
        static void Main()
        {
            int[] numbers = new int[150];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }

            Console.WriteLine("Using Lambda expressions:");
            var divisibleNumbers = numbers.Where(x => (x % 3) == 0 && (x % 7 == 0));
            foreach (var number in divisibleNumbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();
            Console.WriteLine("Using LINQ:");
            var divNumbers = from number in numbers
                             where number % 3 == 0 && number % 7 == 0
                             select number;
            foreach (var number in divNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
