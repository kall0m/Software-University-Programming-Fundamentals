using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circles_Intersection
{
    class Program
    {
        class Circle
        {
            public Point Center { get; set; }
            public double Radius { get; set; }
        }

        class Point
        {
            public double X { get; set; }
            public double Y { get; set; }
        }

        static void Main(string[] args)
        {
            Circle circle1 = ReadCircle();
            Circle circle2 = ReadCircle();

            Console.WriteLine(Intersect(circle1, circle2) ? "Yes" : "No");
        }

        static Circle ReadCircle()
        {
            var circleInfo = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Circle circle = new Circle()
            {
                Center = ReadPoint(circleInfo),
                Radius = circleInfo[2]
            };

            return circle;
        }

        static Point ReadPoint(double[] circleInfo)
        {
            return new Point()
            {
                X = circleInfo[0],
                Y = circleInfo[1]
            };
        }

        static bool Intersect(Circle c1, Circle c2)
        {
            double distance = CalcDistance(c1.Center, c2.Center);

            return distance <= c1.Radius + c2.Radius;
        }

        static double CalcDistance(Point p1, Point p2)
        {
            double a = p1.Y - p2.Y;
            double b = p1.X - p2.X;

            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }
    }
}
