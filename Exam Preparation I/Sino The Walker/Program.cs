using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            var leaveTime = DateTime.ParseExact(Console.ReadLine(), "H:m:s", CultureInfo.InvariantCulture);
            var steps = long.Parse(Console.ReadLine());
            var timeForStepInSeconds = long.Parse(Console.ReadLine());

            var seconds = steps * timeForStepInSeconds;
            var minutes = seconds / 60;
            seconds %= 60;
            var hours = minutes / 60;
            minutes %= 60;
            hours %= 24;

            leaveTime = leaveTime.AddSeconds(seconds);
            leaveTime = leaveTime.AddMinutes(minutes);
            leaveTime = leaveTime.AddHours(hours);

            Console.WriteLine($"Time Arrival: {leaveTime.ToString("HH:mm:ss")}");
        }
    }
}
