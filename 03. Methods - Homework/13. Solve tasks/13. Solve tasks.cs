/*•	Write a program that can solve these tasks:
    o	Reverses the digits of a number
    o	Calculates the average of a sequence of integers
    o	Solves a linear equation a * x + b = 0
  •	Create appropriate methods.
  •	Provide a simple text-based menu for the user to choose which task to solve.
  •	Validate the input data:
    o	The decimal number should be non-negative
    o	The sequence should not be empty
    o	a should not be equal to 0*/

using System;

class SolveTasks
{
    private static double ReverseNum(double number)
    {
        string num = number.ToString();
        char[] numChar = num.ToCharArray();
        Array.Reverse(numChar);
        string result = new string(numChar);
        return double.Parse(result);
    }
    private static int[] MakeArr(string input)
    {
        string[] arrInput = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = new int[arrInput.Length];
        numbers = new int[arrInput.Length];

        for (int index = 0; index < numbers.Length; index++)
        {
            numbers[index] = int.Parse(arrInput[index]);
        }
        return numbers;
    }
    private static double AverageSum(int[]numbers)
    {
        double sum = 0;
        int counter = numbers.Length;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return (double)sum / counter;
    }
    private static double SolveLinearEquation(double a,double b)
    {
        return -b / a;
    }
    static void Main()
    {
        Console.WriteLine("Choose a task to solve:");
        Console.WriteLine(new string('_',60));
        Console.WriteLine();
        Console.WriteLine("Press 1 to reverse the digits of a number");
        Console.WriteLine("Press 2 to calculate the average of a sequence of integers");
        Console.WriteLine("Press 3 to solve a linear equation a*x+b=0");
        Console.WriteLine(new string('_', 60));
        var key = Console.ReadKey();

        switch(key.KeyChar)
        {
            case '1':
                Console.Clear();
                Console.Write("Please enter a non-negative number: ");
                double number=double.Parse(Console.ReadLine());
                if (number<0)
                {
                    throw new FormatException("The number must be positive!");
                }
                else
                {
                    Console.WriteLine("Reversed number is "+ReverseNum(number));
                }
                break;
            case'2':
                Console.Clear();
                Console.WriteLine("Enter the sequence of numbers, separated by commma or space:");
                string input = Console.ReadLine();
                if (input==string.Empty)
                {
                    throw new FormatException("String cannot be empty or equal to zero!");
                }
                else
                {
                    int[] result= MakeArr(input);
                    Console.WriteLine("Average sum of the sequence is {0:F3}",AverageSum(result));   
                }
 
                break;
            case'3':
                Console.Clear();
                Console.Write("Enter coefficient a: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Enter coefficient b: ");
                double b = double.Parse(Console.ReadLine());
               
                if (a==0)
                {
                    throw new FormatException("a cannot be zero!");
                }
                else
                {
                    Console.WriteLine("The equation is {0}x{1}{2}=0", a, b<0? "":"+",b);
                    Console.WriteLine("x={0:F3} ",SolveLinearEquation(a,b));
                }
                break;
            default:
                Console.Clear();
                Console.WriteLine("Invalid input");break;
        }
    }
}

