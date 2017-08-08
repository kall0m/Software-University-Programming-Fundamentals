using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double coordinateX1 = double.Parse(Console.ReadLine());
            double coordinateY1 = double.Parse(Console.ReadLine());
            double coordinateX2 = double.Parse(Console.ReadLine());
            double coordinateY2 = double.Parse(Console.ReadLine());

            ClosestPointToCenterOfCoordinateSystem(coordinateX1, coordinateY1, coordinateX2, coordinateY2);
        }

        static void ClosestPointToCenterOfCoordinateSystem(double coordinateX1, double coordinateY1, double coordinateX2, double coordinateY2)
        {
            double distance1 = Math.Sqrt(coordinateX1 * coordinateX1 + coordinateY1 * coordinateY1);
            double distance2 = Math.Sqrt(coordinateX2 * coordinateX2 + coordinateY2 * coordinateY2);

            if(distance1 < distance2)
            {
                Console.WriteLine($"({coordinateX1}, {coordinateY1})");
            }
            else
            {
                Console.WriteLine($"({coordinateX2}, {coordinateY2})");
            }
        }
    }
}
