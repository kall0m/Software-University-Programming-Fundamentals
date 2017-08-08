using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double cubeSide = double.Parse(Console.ReadLine());
            string cubeParameter = Console.ReadLine().ToLower();

            switch (cubeParameter)
            {
                case "face": Console.WriteLine($"{CalculateCubesFace(cubeSide):F2}"); break;
                case "space": Console.WriteLine($"{CalculateCubesSpace(cubeSide):F2}"); break;
                case "volume": Console.WriteLine($"{CalculateCubesVolume(cubeSide):F2}"); break;
                case "area": Console.WriteLine($"{CalculateCubesArea(cubeSide):F2}"); break;
            }
        }

        static double CalculateCubesFace(double side)
        {
            return Math.Sqrt(2 * side * side);
        }

        static double CalculateCubesSpace(double side)
        {
            return Math.Sqrt(3 * side * side);
        }

        static double CalculateCubesVolume(double side)
        {
            return side * side * side;
        }

        static double CalculateCubesArea(double side)
        {
            return 6 * side * side;
        }
    }
}
