//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

using System;

namespace _06.MaximalKSum
{
    class MaximalKSum
    {
        static void Main()
        {
            Console.Write("Enter the size N of the array: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Enter the elements K with maximal sum: ");
            int K = int.Parse(Console.ReadLine());
            int[] numArr = new int[N];

            if (K > N)
            {
                Console.WriteLine("Operation can't be done.The size of the array N is smaller than the elements K!");
            }
            else
            {
                for (int i = 0; i < numArr.Length; i++)
                {
                    Console.Write("Enter element [{0}] of the array: ", i);
                    numArr[i] = int.Parse(Console.ReadLine());
                }
                Array.Sort(numArr);

                Console.WriteLine("The {0} elements with maximal sum are:",K);

                for (int j = numArr.Length-K; j <numArr.Length; j++)
                {
                    Console.Write(j != numArr.Length-1 ? numArr[j] + ", " : numArr[j] + "\n ");
                }
            }
            Main();
        }

    }
}
