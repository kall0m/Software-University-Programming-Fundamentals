using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Closest_Two_Points
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
            Point[] points = ReadPoints();

            Point[] closestPoints = FindClosestPoints(points);

            PrintDistance(closestPoints);

            PrintPoint(closestPoints[0]);
            PrintPoint(closestPoints[1]);
        }

        static void PrintPoint(Point point)
        {
            Console.WriteLine($"({point.X}, {point.Y})");
        }

        static void PrintDistance(Point[] points)
        {
            double distance = CalcDistance(points[0], points[1]);

            Console.WriteLine($"{distance:F3}");
        }

        static Point[] FindClosestPoints(Point[] points)
        {
            List<Point> closestPoints = new List<Point>();

            double shortestDistance = double.MaxValue;

            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    double distanceBetweenTwoPoints = CalcDistance(points[i], points[j]);

                    if(shortestDistance > distanceBetweenTwoPoints)
                    {
                        shortestDistance = distanceBetweenTwoPoints;

                        closestPoints = new List<Point>();

                        closestPoints.Add(points[i]);
                        closestPoints.Add(points[j]);
                    }
                }
            }

            return closestPoints.ToArray();
        }

        static double CalcDistance(Point p1, Point p2)
        {
            int a = p1.Y - p2.Y;
            int b = p1.X - p2.X;

            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }

        static Point[] ReadPoints()
        {
            int n = int.Parse(Console.ReadLine());

            Point[] points = new Point[n];

            for (int i = 0; i < n; i++)
            {
                points[i] = ReadPoint();
            }

            return points;
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
    }
}
