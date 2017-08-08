using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            double bpm = int.Parse(Console.ReadLine());
            double beats = int.Parse(Console.ReadLine());

            double bars = Math.Round(beats / 4.0, 1);
            double lenghtSeconds = Math.Floor((beats / bpm) * 60);
            double lenghtMinutes = (int)lenghtSeconds / 60;
            lenghtSeconds %= 60;

            Console.WriteLine($"{bars} bars - {lenghtMinutes}m {lenghtSeconds}s");

        }
    }
}
