/*Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than
the second one. As a result print the values a and b, separated by a space.*/

using System;

namespace ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            Console.Write("Please enter double number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Please enter another double number: ");
            double b = double.Parse(Console.ReadLine());
            if (a>b)
            {
                double change = a; 
                a = b;
                b = change;

            }
            Console.WriteLine(a+" "+ b);

        }
    }
}
