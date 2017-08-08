using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine().ToLower();

            switch (figureType)
            {
                case "triangle": Console.WriteLine($"{TriangleArea():F2}"); break;
                case "square": Console.WriteLine($"{SquareArea():F2}"); break;
                case "rectangle": Console.WriteLine($"{RectangleArea():F2}"); break;
                case "circle": Console.WriteLine($"{CircleArea():F2}"); break;
            }
        }

        static double TriangleArea()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            return (side * height) / 2;
        }

        static double SquareArea()
        {
            double side = double.Parse(Console.ReadLine());

            return side * side;
        }

        static double RectangleArea()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            return width * height;
        }

        static double CircleArea()
        {
            double radius = double.Parse(Console.ReadLine());

            return Math.PI * radius * radius;
        }
    }
}
