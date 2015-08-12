namespace LongestString
{
    using System;
    using System.Linq;

    class LongestString
    {
        static void Main()
        {
            string[] testStrings = new string[]
            {
                "definition",
                "exercise",
                "object-oriented programming",
                "console application",
                "project"
            };

            Console.WriteLine("The longest string in the array of strings is:");
            Console.WriteLine(GetLongetsString(testStrings));
        }

        public static string GetLongetsString(string[] strArray)
        {
            var longest = from str in strArray
                          orderby str.Length descending
                          select str;
            return longest.ToArray()[0];
        }
    }
}
