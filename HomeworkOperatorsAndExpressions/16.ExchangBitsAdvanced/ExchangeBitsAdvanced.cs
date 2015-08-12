
namespace BitExchange_Advances
{
    using System;
    class BitExchange_Advances
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            long number = long.Parse(Console.ReadLine());
            Console.Write("Enter position P: ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Enter position Q: ");
            int q = int.Parse(Console.ReadLine());
            Console.Write("Enter step K: ");
            int k = int.Parse(Console.ReadLine());

            for (int i = p, j = q, l = k; (i <= 32 && j <= 32) && l > 0; i++, j++, l--)
            {
                if (((number >> i) & 1) != ((number >> j) & 1))
                {
                    number = changeBits(number, i, j);
                }
            }
            Console.WriteLine("Result: " + number);
        }

        private static long changeBits(long number, int firstposition, int secondPosition)
        {
            number ^= (1 << firstposition);
            return number ^ (1 << secondPosition);
        }
    }
}