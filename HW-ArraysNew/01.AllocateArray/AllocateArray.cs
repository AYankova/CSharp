//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.

using System;

namespace AllocatingArray
{
    class AllocatingArray
    {
        static void Main()
        {
            int[] intArray = new int[20];

            for (int index = 0; index < intArray.Length; index++)
            {
                intArray[index] = index * 5;

                Console.Write(index != intArray.Length - 1 ? intArray[index] + ", " : intArray[index] + "\n");
            }

        }
    }
}
