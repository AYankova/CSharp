namespace GenericList
{
    using System;

    class GenericListTest
    {
        static void Main()
        {
            GenericList<int> test = new GenericList<int>();
            GenericList<int> test1 = new GenericList<int>(5);

            for (int i = 0; i < 10; i++)
            {
                test.AddElement(i + 1);
                Console.WriteLine("Element {0,5}    Count {1,5}    Capacity {2,5}",test[i],test.Count,test.Capacity);
            }

            Console.WriteLine();
            for (int i = 0; i < test1.Capacity; i++)
            {
                test1.AddElement(i + 10);
                Console.WriteLine("Element {0,5}    Count {1,5}    Capacity {2,5}", test1[i], test1.Count, test1.Capacity);
            }

            Console.WriteLine();
            test.InsertAt(1, 22);
            Console.WriteLine(test);
            Console.WriteLine("New length: {0}",test.Count);
            Console.WriteLine();
            test1.RemoveAt(2);
            Console.WriteLine(test1);
            Console.WriteLine("New length: {0}",test1.Count);

            Console.WriteLine();
            Console.WriteLine("Min: {0}",test.Min());
            Console.WriteLine("Max: {0}",test.Max());
        }
    }
}
