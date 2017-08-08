using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            double maxKegVolume = 0.0;
            string biggestKeg = "";

            for (int i = 0; i < lines; i++)
            {
                string kegModel = Console.ReadLine();
                double kegRadius = double.Parse(Console.ReadLine());
                int kegHeight = int.Parse(Console.ReadLine());

                double kegVolume = Math.PI * kegRadius * kegRadius * kegHeight;

                if (maxKegVolume < kegVolume)
                {
                    maxKegVolume = kegVolume;
                    biggestKeg = kegModel;
                }
            }

            Console.WriteLine(biggestKeg);
        }
    }
}
