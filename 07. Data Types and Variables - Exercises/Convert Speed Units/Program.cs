using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            float distanceInMeters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float metersPerSecond = distanceInMeters / (hours * 3600 + minutes * 60 + seconds);

            hours = hours + minutes / 60 + seconds / 3600;

            float distanceInKilometers = distanceInMeters / 1000;
            float kilometersPerHour = distanceInKilometers / hours;

            float distanceInMiles = distanceInMeters / 1609;
            float milesPerHour = distanceInMiles / hours;

            Console.WriteLine($"{metersPerSecond}");
            Console.WriteLine($"{kilometersPerHour}");
            Console.WriteLine($"{milesPerHour}");
        }
    }
}
