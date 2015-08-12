namespace _08.TimerEvent
{
    using System;

    class TimerEvent
    {
        static void Main()
        {
            Console.Write("Enter the interval (in seconds) for timer 1: ");
            int duration1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the interval (in seconds) for timer 2: ");
            int duration2 = int.Parse(Console.ReadLine());

            Clock clock = new Clock();
            clock.Run();

            Timers timer1 = new Timers(1, clock, duration1);
            Timers timer2 = new Timers(2, clock, duration2);

            Console.ReadLine();

        }
    }
}
