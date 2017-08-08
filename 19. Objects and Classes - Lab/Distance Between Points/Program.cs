using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance_Between_Points
{
    class Program
    {
        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        static void Main(string[] args)
        {
            Point p1 = ReadPoint();
            Point p2 = ReadPoint();

            double distance = CalcDistance(p1, p2);

            Console.WriteLine($"{distance:F3}");
        }

        static Point ReadPoint()
        {
            var pointCords = Console.ReadLine().Split().ToList();

            Point point = new Point()
            {
                X = int.Parse(pointCords[0]),
                Y = int.Parse(pointCords[1]),
            };

            return point;
        }

        static double CalcDistance(Point p1, Point p2)
        {
            int a = p1.Y - p2.Y;
            int b = p1.X - p2.X;

            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }
    }
}
