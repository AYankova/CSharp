namespace _03.RangeExceptions
{
    using System;

    class RangeExceptionsTest
    {
        static void Main()
        {
            try
            {
                throw new InvalidRangeException<int>(4, 8);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); ;
            }

            try
            {
                throw new InvalidRangeException<DateTime>(DateTime.Now, DateTime.Now.AddDays(7));
            }
            catch (Exception ex)
            {
                
              Console.WriteLine(ex.Message);
            }
        }
    }
}
