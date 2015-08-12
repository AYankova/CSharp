//Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers).
//The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//The card faces should start from 2 to A.
//Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and 
//a switch-case statement.

using System;

namespace _04.PrintADeckOf52Cards
{
    class PrintADeckOf52Cards
    {
        static void Main()
        {
            string[] suitArr = { "spades", "clubs", "hearts", "diamonds" };


            for (int j = 2; j <= 14; j++)
            {
                for (int i = 0; i < suitArr.Length; i++)
                {
                    switch (j)
                    {
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                        case 10:
                            Console.Write("{0} of {1}", j, suitArr[i]); break;
                        case 11: Console.Write("J of " + suitArr[i]); break;
                        case 12: Console.Write("Q of " + suitArr[i]); break;
                        case 13: Console.Write("K of " + suitArr[i]); break;
                        case 14: Console.Write("A of " + suitArr[i]); break;
                    }

                    if (i < suitArr.Length - 1)
                    {
                        Console.Write(", ");
                    }
                }

                Console.WriteLine();

            }

        }
    }
}
