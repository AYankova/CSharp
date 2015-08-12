//•	Write a program to check if in a given expression the brackets are put correctly.

//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b))

using System;

class CorrectBrackets
{
    static void Main()
    {
        Console.WriteLine("Enter the expression:");
        string input = Console.ReadLine();
        int count = 0;

        foreach (char symbol in input)
        {
            if (symbol=='(')
            {
                ++count;  
            }
            else if (symbol==')')
            {
                --count;
            }
        }
        if (count==0)
        {
            Console.WriteLine("Correct brackets!"); 
        }
        else
        {
            Console.WriteLine("Incorrect brackets!");
        }
      
    }
}

