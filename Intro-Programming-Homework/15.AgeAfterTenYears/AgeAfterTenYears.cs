using System;

class AgeAfterTenYears
{
    static void Main()
    {
        //Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

        Console.WriteLine("Input your age and press enter:");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("You age in 10 years will be {0}", age + 10);
    }
}
