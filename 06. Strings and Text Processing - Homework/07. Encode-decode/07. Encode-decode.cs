/*•	Write a program that encodes and decodes a string using given encryption key (cipher).
  •	The key consists of a sequence of characters.
  •	The encoding/decoding is done by performing XOR (exclusive or) operation over the first 
  * letter of the string with the first of the key, the second – with the second, etc. When 
  * the last key character is reached, the next is the first.*/

using System;
using System.Text;

class EncodeDecode
{
    static string Encode(string s, string key)
    {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < s.Length; i++)
        {
            result.Append((char)(s[i] ^ key[i % key.Length]));

        }
        return result.ToString();
    }
    static string Decode(string str,string key)
    {
        return Encode(str, key);
    }
        static void Main()
    {

        Console.Write("Enter the text: ");
        string input = Console.ReadLine();
        Console.Write("Enter the cypher: ");
        string cypher = Console.ReadLine();
       
        Console.WriteLine();
        string encoded=Encode(input,cypher);
        Console.WriteLine("Encoded text is:\n"+encoded);
        Console.WriteLine();
        string decoded = Decode(encoded, cypher);
        Console.WriteLine("Decoded text is:\n"+decoded);

    }
}
