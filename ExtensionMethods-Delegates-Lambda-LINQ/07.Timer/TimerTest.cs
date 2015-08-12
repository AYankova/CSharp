namespace Timer
{
    using System;
    using System.Threading;

    class TimerTest
    {
        static void Main()
        {
            Timer timer1 = new Timer(2,5);
            Timer timer2 = new Timer(2);

            timer1.timerEvent += Test1;
            timer1.timerEvent += Test2;
            timer1.Run();  //executed 5 times
            Console.WriteLine();
            timer2.timerEvent += Test3;
            timer2.Run();  //executed 255 times
        }
        public static void Test1()
        {
            Console.WriteLine("Test1");
        }

        public static void Test2()
        {
            Console.WriteLine("Test2");
        }

        public static void Test3()
        {
            Console.WriteLine("Test3");
        }
    }
}
