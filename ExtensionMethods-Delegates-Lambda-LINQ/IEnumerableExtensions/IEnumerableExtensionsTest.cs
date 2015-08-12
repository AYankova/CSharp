namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;

    class IEnumerableExtensionsTest
    {
        static void Main()
        {
            IEnumerable <int> intArr =new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            IEnumerable<double> dblArr =new[] { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7, 8.8, 9.9 };

            Console.WriteLine("Sum of: ");
            Console.WriteLine("Integer array: {0}", intArr.Sum());
            Console.WriteLine("Double array: {0}", dblArr.Sum());

            Console.WriteLine();
            Console.WriteLine("Product of: ");
            Console.WriteLine("Integer array: {0}", intArr.Product());
            Console.WriteLine("Double array: {0}", dblArr.Product());

            Console.WriteLine();
            Console.WriteLine("Average of: ");
            Console.WriteLine("Integer array: {0}", intArr.Average());
            Console.WriteLine("Double array: {0}", dblArr.Average());

            Console.WriteLine();
            Console.WriteLine("Min of: ");
            Console.WriteLine("Integer array: {0}", intArr.Min());
            Console.WriteLine("Double array: {0}", dblArr.Min());

            Console.WriteLine();
            Console.WriteLine("Max of: ");
            Console.WriteLine("Integer array: {0}", intArr.Max());
            Console.WriteLine("Double array: {0}", dblArr.Max()); 
        }
    }
}
