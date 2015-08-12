//Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation

using System;

namespace NumbersAsWords
{
    class NumbersAsWords
    {
        static void Main()
        {
            Console.Write("Please enter an integer number between 0 and 999: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if ((number<0) || (number>999))
            {
                Console.WriteLine("Incorrect number");
            }
            else
            {
                int hundreds= number / 100;
                int tens= (number / 10) % 10;
                int digits= number % 10;
                int elevenToNineteenInt = 10 + digits;
                string hundredsStr = "";
                string elevenToNineteen = "";
                string tensStr = "";
                string digitsStr="";
                switch (hundreds)
                {
                    case 1: hundredsStr = "one hundred "; break;
                    case 2: hundredsStr = "two hundred "; break;
                    case 3: hundredsStr = "three hundred "; break;
                    case 4: hundredsStr = "four hundred "; break;
                    case 5: hundredsStr = "five hundred "; break;
                    case 6: hundredsStr = "six hundred "; break;
                    case 7: hundredsStr = "seven hundred "; break;
                    case 8: hundredsStr = "eight hundred "; break;
                    case 9: hundredsStr = "nine hundred "; break;
                    case 0: hundredsStr = ""; break;
                }
                if (number % 100 != 0 && number >= 100)
                {
                    hundredsStr= hundredsStr + "and ";
                }
                switch (elevenToNineteenInt)
                {
                    case 11: elevenToNineteen = "eleven"; break;
                    case 12: elevenToNineteen = "twelve"; break;
                    case 13: elevenToNineteen = "thirteen"; break;
                    case 14: elevenToNineteen = "fourteen"; break;
                    case 15: elevenToNineteen = "fifteen"; break;
                    case 16: elevenToNineteen = "sixteen"; break;
                    case 17: elevenToNineteen = "seventeen"; break;
                    case 18: elevenToNineteen = "eighteen"; break;
                    case 19: elevenToNineteen = "nineteen"; break;
                }
                if (tens == 1 && digits > 0)
                {
                    Console.WriteLine(hundredsStr + elevenToNineteen);
                    hundredsStr = tensStr = "";
                }
                else
                {

                    switch (tens)
                    {
                        case 1: tensStr = "ten"; break;
                        case 2: tensStr = "twenty "; break;
                        case 3: tensStr = "thirty "; break;
                        case 4: tensStr = "fourty "; break;
                        case 5: tensStr = "fifty "; break;
                        case 6: tensStr = "sixty "; break;
                        case 7: tensStr = "seventy "; break;
                        case 8: tensStr = "eighty "; break;
                        case 9: tensStr = "ninety "; break;
                        case 0: tensStr = ""; break;
                    }

                    switch (digits)
                    {
                        case 1: digitsStr = "one"; break;
                        case 2: digitsStr = "two"; break;
                        case 3: digitsStr = "three"; break;
                        case 4: digitsStr = "four"; break;
                        case 5: digitsStr = "five"; break;
                        case 6: digitsStr = "six"; break;
                        case 7: digitsStr = "seven"; break;
                        case 8: digitsStr = "eight"; break;
                        case 9: digitsStr = "nine"; break;
                        default: digitsStr = ""; break;
                    }


                    if (number == 0)
                    {
                        Console.WriteLine("Zero");
                        hundredsStr = tensStr = digitsStr = "";
                    }
                    if (number <= 10 || number >= 20)
                    {
                        Console.WriteLine(hundredsStr + tensStr + digitsStr);
                    }
                }



            }


        }
    }
}
