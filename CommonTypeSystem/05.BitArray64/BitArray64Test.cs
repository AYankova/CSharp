namespace _05.BitArray64
{
    using System;

    class BitArray64Test
    {
        static void Main()
        {
            BitArray64 number = new BitArray64(120u);
            BitArray64 num = new BitArray64(100u);

            Console.WriteLine(number);
            Console.WriteLine(number.Length);
            Console.WriteLine(number[3]);
            number[3] = 0;
            Console.WriteLine(number);

            Console.WriteLine(num.Equals(number));
            Console.WriteLine(num == number);
            Console.WriteLine(num != number);

            Console.WriteLine(num.GetHashCode());
            Console.WriteLine(number.GetHashCode());
        }
    }
}
