namespace Substring
{
    using System;
    using System.Text;

    class SubstringTest
    {
        static void Main()
        {
            StringBuilder test = new StringBuilder("This is some sample input for testing purposes");

            StringBuilder test1 = test.Substring(13, 6); //first way to call the method with startindex and length
            StringBuilder test2 = SubstringClass.Substring(test, 13, 6); //second way to call the method with startindex and length

            Console.WriteLine("Results: ");
            Console.WriteLine();
            Console.WriteLine(test1);
            Console.WriteLine(test2);
            Console.WriteLine();

            StringBuilder test3 = test.Substring(13); //first way to call the method with only startindex
            StringBuilder test4 = SubstringClass.Substring(test, 13);//second way to call the method with only startindex

            Console.WriteLine(test3);
            Console.WriteLine(test4);
        }
    }
}
