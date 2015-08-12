/*•	Write a program that reads a number and prints it as a decimal number, hexadecimal number, 
    percentage and in scientific notation.
  •	Format the output aligned right in 15 symbols.*/

using System;

class FormatNumber
{
    static void Main()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Enter a number:");
                int number = int.Parse(Console.ReadLine());

                Console.WriteLine("Decimal representation    :{0}",string.Format("{0,15:D}",number));
                Console.WriteLine("Hexadecimal representation:{0}",string.Format("{0,15:X}",number));
                Console.WriteLine("Percentage representation :{0}",string.Format("{0,15:P0}",number/100.0));
                Console.WriteLine("Scientific representation :{0}",string.Format("{0,15:E}",number));
            }
            catch (FormatException)
            {
                Console.WriteLine("Parsing failed!Incorrect number entered!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error!"+ex.Message);
            }
        }
    }
}

