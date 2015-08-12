using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenDifferences
{
    class Program
    {
        static void Main()
        {
            long[] input = Console.ReadLine().Split(' ').Select(x => Int64.Parse(x)).ToArray();
            long result = 0;
            int i = 1;
            while(i <input.Length)
            {
                if (Math.Abs(input[i]-input[i-1])%2==0)
                {
                    result+=Math.Abs(input[i]-input[i-1]);
                    i += 2;
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine(result);
        }
    }
}
