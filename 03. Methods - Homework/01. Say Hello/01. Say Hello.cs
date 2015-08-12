// Write a method that asks the user for his name and prints “Hello, <name>”
// Write a program to test this method.

using System;

class SayHello
{
    private static void SayHi(string name)
    {
        Console.WriteLine("Hello, {0}!",name);
    }
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        SayHi(name);
    }
}
