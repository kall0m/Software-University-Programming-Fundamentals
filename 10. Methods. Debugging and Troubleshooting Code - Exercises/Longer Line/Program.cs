using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double coordinateX1 = double.Parse(Console.ReadLine());
            double coordinateY1 = double.Parse(Console.ReadLine());
            double coordinateX2 = double.Parse(Console.ReadLine());
            double coordinateY2 = double.Parse(Console.ReadLine());
            double coordinateX3 = double.Parse(Console.ReadLine());
            double coordinateY3 = double.Parse(Console.ReadLine());
            double coordinateX4 = double.Parse(Console.ReadLine());
            double coordinateY4 = double.Parse(Console.ReadLine());

            double line1 = DistanceOfLine(coordinateX1, coordinateY1, coordinateX2, coordinateY2);
            double line2 = DistanceOfLine(coordinateX3, coordinateY3, coordinateX4, coordinateY4);

            if (line1 >= line2)
            {
                PrintTheClosestPointToCenterOfCoordinateSystemFirst(coordinateX1, coordinateY1, coordinateX2, coordinateY2);
            }
            else
            {
                PrintTheClosestPointToCenterOfCoordinateSystemFirst(coordinateX3, coordinateY3, coordinateX4, coordinateY4);
            }
        }

        static double DistanceOfLine(double coordinateX1, double coordinateY1, double coordinateX2, double coordinateY2)
        {
            return Math.Sqrt((coordinateX1 - coordinateX2) * (coordinateX1 - coordinateX2) + (coordinateY1 - coordinateY2) * (coordinateY1 - coordinateY2));
        }

        static void PrintTheClosestPointToCenterOfCoordinateSystemFirst(double coordinateX1, double coordinateY1, double coordinateX2, double coordinateY2)
        {
            double distance1 = Math.Sqrt(coordinateX1 * coordinateX1 + coordinateY1 * coordinateY1);
            double distance2 = Math.Sqrt(coordinateX2 * coordinateX2 + coordinateY2 * coordinateY2);

            if (distance1 <= distance2)
            {
                Console.Write($"({coordinateX1}, {coordinateY1})({coordinateX2}, {coordinateY2})");
            }
            else
            {
                Console.Write($"({coordinateX2}, {coordinateY2})({coordinateX1}, {coordinateY1})");
            }
        }
    }
}
