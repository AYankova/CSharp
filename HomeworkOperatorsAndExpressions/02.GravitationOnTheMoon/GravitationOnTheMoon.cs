/*The gravitational field of the Moon is approximately 17% of that on the Earth.
Write a program that calculates the weight of a man on the moon by a given weight on the Earth.*/

using System;
using System.Threading;
using System.Globalization;

namespace GravitationOnTheMoon
{
    class GravitationOnTheMoon
    {
        static void Main()
        {
           Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
           Console.WriteLine("Enter your weight:");
           double weightOnEarth = Convert.ToDouble(Console.ReadLine());
           double weightOnMoon = 0.17*weightOnEarth;
           Console.WriteLine("Your weight on moon is "+weightOnMoon);

        }
    }
}
