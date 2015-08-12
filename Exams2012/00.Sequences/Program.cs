using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Sequences
{
    class Program
    {
        
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                double[] numbers = Console.ReadLine().Split(' ').Select(x => Convert.ToDouble(x)).ToArray();
                double[] resultaAbsolute = new double[numbers.Length - 1];
                for (int j = 0; j < numbers.Length-1; j++)
                {
                    resultaAbsolute[j] = (double)Math.Abs(numbers[j]- numbers[j + 1]);
                }
                bool isDesc = false;
               
                double[] values = new double[resultaAbsolute.Length - 1];

                for (int m = 0; m < resultaAbsolute.Length-1; m++)
                {
                    values[m] = Math.Abs(resultaAbsolute[m] - resultaAbsolute[m + 1]);
                }
                for (int m = 0; m < values.Length; m++)
                {   
                if ((values[m]!=0) && (values[m] !=1))
                    {
                        isDesc = false;
                        break;
                    }
                        isDesc = true;
                }
                bool isHiger = false;
                for (int k = 0; k < resultaAbsolute.Length-1; k++)
                {
                    if (resultaAbsolute[k]>resultaAbsolute[k+1])
                    {
                        isHiger = false; break;
                    }
                    isHiger = true;
                }
            
                bool result = isHiger && isDesc;
                 sb.AppendLine(result.ToString());
            }
            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
