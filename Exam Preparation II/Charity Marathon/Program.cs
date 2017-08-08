using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            var marathonDurationInDays = long.Parse(Console.ReadLine());
            var numberOfRunners = long.Parse(Console.ReadLine());
            var averageNumberOfLaps = long.Parse(Console.ReadLine());
            var trackLength = long.Parse(Console.ReadLine());
            var trackCapacity = long.Parse(Console.ReadLine());
            var donatedMoneyPerKilometer = double.Parse(Console.ReadLine());

            if(numberOfRunners > trackCapacity * marathonDurationInDays)
            {
                numberOfRunners = trackCapacity * marathonDurationInDays;
            }

            var totalRunnedMeters = numberOfRunners * averageNumberOfLaps * trackLength;
            var totalRunnedKilometers = totalRunnedMeters / 1000;
            var moneyRaised = totalRunnedKilometers * donatedMoneyPerKilometer;

            Console.WriteLine("Money raised: {0:F2}", moneyRaised);
        }
    }
}
