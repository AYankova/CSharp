/*Write a program that enters 3 real numbers and prints them sorted in descending order.
Use nested if statements.*/

using System;

namespace Sort3NumbersWithNestedIfs
{
    class Sort3NumbersWithNestedIfs
    {
        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            Console.Write("Please enter first number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Please enter second number: ");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.Write("Please enter third number: ");
            double thirdNumber = double.Parse(Console.ReadLine());
            if (firstNumber > secondNumber)
            {
                if (secondNumber > thirdNumber)
                {
                    Console.WriteLine(firstNumber+" "+secondNumber+" "+thirdNumber);
                }
                else 
                {
                    if(firstNumber>thirdNumber)
                    {
                          Console.WriteLine(firstNumber+" "+thirdNumber+" "+secondNumber);
                    }
                    else 
                        {
                            Console.WriteLine(thirdNumber+" "+firstNumber+" "+secondNumber);
                        }
                }
                
            }
                else
                {
                if(firstNumber>thirdNumber)
                {
                    Console.WriteLine(secondNumber+" "+firstNumber+" "+thirdNumber);
                }
                else 
                {
                    if (secondNumber<thirdNumber)
                    {
                        Console.WriteLine(thirdNumber+" "+secondNumber+" "+firstNumber);
                    }
                    else
                    {
                        Console.WriteLine(secondNumber+" "+thirdNumber+" "+firstNumber);
                    }
                }

                }

               
        }
    }
}
