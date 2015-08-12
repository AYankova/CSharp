namespace MobilePhone
{
    using System;

    public class DefiningClassesPartI_Main
    {
        private static void Main()
        {
            GSMTest.PrintGSMsInfo();
            Console.WriteLine(new string('-', 60));
            
            GSMCallHistoryTest.CreateTestCallHistory();
            GSMCallHistoryTest.PrintTestCallHistory();
            Console.WriteLine();
            GSMCallHistoryTest.CalculateAndPrintTestCallsPrice();
            GSMCallHistoryTest.RemoveLongestCall();
            Console.WriteLine();
            Console.WriteLine("Call history after the longest call is removed:");
            GSMCallHistoryTest.PrintTestCallHistory();
            Console.WriteLine();
            Console.WriteLine("Price after the longest call is removed:");
            GSMCallHistoryTest.CalculateAndPrintTestCallsPrice();
            Console.WriteLine();
            GSMCallHistoryTest.testGSM.ClearCallHistory();
            Console.WriteLine("Call history after it's been cleared: ");
            GSMCallHistoryTest.PrintTestCallHistory();
        }
    }
}
