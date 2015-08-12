using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class VariableLengthCode
{
    static void Main()
    {
        string[] encodedText=Console.ReadLine().Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries).ToArray();
        byte[] encodedNumbers = new byte[encodedText.Length];
        for (int i = 0; i < encodedNumbers.Length; i++)
        {
            encodedNumbers[i]=byte.Parse(encodedText[i]);
        }
        
        StringBuilder sb = new StringBuilder();
        foreach (var number in encodedNumbers)
        {
            sb.Append(Convert.ToString(number, 2).PadLeft(8, '0'));
        }
        string[] encodedSymbols = sb.ToString().Split(new char[] { '0' }, StringSplitOptions.RemoveEmptyEntries);

        int lines = int.Parse(Console.ReadLine());
        //string[] codeTable = new string[lines];
        char[] symbolPerCodeLength = new char[lines + 1];
        for (int j = 0; j < lines; j++)
        {
            string currentPair = Console.ReadLine();
            char symbol = currentPair[0];
            int codeLength=int.Parse(currentPair.Substring(1));
            symbolPerCodeLength[codeLength] = symbol;
        }

        for (int i = 0; i < encodedSymbols.Length; i++)
        {
            var codedSymbol = encodedSymbols[i];
            Console.Write(symbolPerCodeLength[codedSymbol.Length]);
        }
        Console.WriteLine();
    }
}

