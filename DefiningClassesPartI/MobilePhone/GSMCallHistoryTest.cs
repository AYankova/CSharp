namespace MobilePhone
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class GSMCallHistoryTest
    {
        public static GSM testGSM = new GSM("TestModel", "TestManufacturer");

        public static DateTime firstTestDate = new DateTime(2014, 03, 10, 4, 24, 13);
        public static DateTime secondTestDate = new DateTime(2014, 03, 10, 10, 16, 19);
        public static DateTime thirdTestDate = new DateTime(2014, 03, 10, 7, 55, 15);
        public static DateTime fourthTestDate = new DateTime(2014, 03, 10, 1, 14, 14);
        public static DateTime fifthTestDate = new DateTime(2014, 03, 10, 8, 18, 18);

        private static Call[] testCalls =
        {
                                           new Call(firstTestDate, "359888777666", 360),
                                           new Call(secondTestDate, "359888777777", 1200),
                                           new Call(thirdTestDate, "359888777888", 2200),
                                           new Call(fourthTestDate, "359888777999", 200),
                                           new Call(fifthTestDate, "359888777000", 0)
        };

        public static void CreateTestCallHistory()
        {
            for (int i = 0; i < testCalls.Length; i++)
            {
                testGSM.AddCalls(testCalls[i]);
            }
        }

        public static void PrintTestCallHistory()
        {
            Console.WriteLine(testGSM.PrintCallHistory());
        }

        public static void CalculateAndPrintTestCallsPrice()
        {
            decimal price = testGSM.CalculateTotalCallsPrice(0.37M);
            Console.WriteLine("Total price of all calls: {0:F2}", price);
        }

        public static void RemoveLongestCall()
        {
            Call longestCall = new Call(DateTime.Now, "0", 0);

            for (int i = 0; i < testCalls.Length; i++)
            {
                if (testCalls[i].Duration >= longestCall.Duration)
                {
                    longestCall = testCalls[i];
                }
            }

            testGSM.DeleteCalls(longestCall);
        }
    }
}
