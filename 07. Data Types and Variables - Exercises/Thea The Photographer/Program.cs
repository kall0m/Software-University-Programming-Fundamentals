using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long numberOfPictures = int.Parse(Console.ReadLine());
            int pictureFilterTime = int.Parse(Console.ReadLine());
            byte percentageOfGoodPictures = byte.Parse(Console.ReadLine());
            long pictureUploadingTime = int.Parse(Console.ReadLine());

            int filteredPictures = (int) Math.Ceiling(numberOfPictures * percentageOfGoodPictures / 100.0);

            long totalPicturesTime = numberOfPictures * pictureFilterTime;
            long filteredPicturesTime = filteredPictures * pictureUploadingTime;

            long totalTimeInSeconds = totalPicturesTime + filteredPicturesTime;

            int minutes = 0;
            int hours = 0;
            int days = 0;

            while (totalTimeInSeconds >= 86400)
            {
                days++;
                totalTimeInSeconds -= 86400;
            }

            while (totalTimeInSeconds >= 3600)
            {
                hours++;
                totalTimeInSeconds -= 3600;
            }

            while(totalTimeInSeconds >= 60)
            {
                minutes++;
                totalTimeInSeconds -= 60;
            }

            Console.WriteLine($"{days}:{hours:D2}:{minutes:D2}:{totalTimeInSeconds:D2}");
        }
    }
}
