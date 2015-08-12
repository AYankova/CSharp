
namespace MobilePhone
{
    using System;

    public class GSMTest
    {
       public static void PrintGSMsInfo()
       {
           GSM obligatoryFieldsConstructor = new GSM("Some model", "Some manufacturer");
           GSM[] gsms = new GSM[3]
            {
                new GSM("E73", "Nokia", 50, "Ivan", new Battery(Battery.BatteryType.LiIon, 8, 18), new Display(3.4, 16000000)),
                new GSM("1218", "LG", 90, "Peter", new Battery(Battery.BatteryType.LiIon, 14, 25), new Display()),
                new GSM("Galaxy4", "Samsung", 403.5M, "Georgi", new Battery(), new Display(5.2, 16000000))
            };

           Console.WriteLine("Sample GSM, first constructor: {0}", obligatoryFieldsConstructor);
           Console.WriteLine(new string('-', 50));

           for (int i = 0; i < gsms.Length; i++)
           {
               Console.WriteLine("Sample GSM {0}: {1}", i + 1, gsms[i]);
               Console.WriteLine(new string('-', 50));
           }

           Console.WriteLine("IPhone info: {0}", GSM.IPhone4S);
       }
    }
}
