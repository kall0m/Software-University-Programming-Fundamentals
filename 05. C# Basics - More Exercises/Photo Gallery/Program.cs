using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int photoNum = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int size = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            string bytes = "";
            string orientation = "";

            Console.WriteLine($"Name: DSC_{photoNum:D4}.jpg");
            Console.WriteLine($"Date Taken: {day:D2}/{month:D2}/{year} {hours:D2}:{minutes:D2}");
            if(size < 1000)
            {
                bytes = size + "B";
            }
            else if(size < 1000000)
            {
                bytes = size / 1000.0 + "KB";
            }
            else
            {
                bytes = size / 1000000.0 + "MB";
            }
            Console.WriteLine($"Size: {bytes}");

            if (width > height)
            {
                orientation = "landscape";
            }
            else if (width < height)
            {
                orientation = "portrait";
            }
            else
            {
                orientation = "square";
            }
            Console.WriteLine($"Resolution: {width}x{height} ({orientation})");
        }
    }
}
