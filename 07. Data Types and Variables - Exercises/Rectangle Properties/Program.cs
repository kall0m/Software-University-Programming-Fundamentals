using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double triangleHeight = double.Parse(Console.ReadLine());
            double triangleWidth = double.Parse(Console.ReadLine());

            double trianglePerimeter = 2 * (triangleHeight + triangleWidth);
            double triangleArea = triangleHeight * triangleWidth;
            double triangleDiagonal = Math.Sqrt(triangleHeight * triangleHeight + triangleWidth * triangleWidth);

            Console.WriteLine(trianglePerimeter);
            Console.WriteLine(triangleArea);
            Console.WriteLine(triangleDiagonal);
        }
    }
}
