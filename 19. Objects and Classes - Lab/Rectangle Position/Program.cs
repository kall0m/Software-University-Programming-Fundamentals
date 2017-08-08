using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Position
{
    class Program
    {
        class Rectangle
        {
            public double Left { get; set; }
            public double Top { get; set; }
            public double Width { get; set; }
            public double Height { get; set; }

            public double Bottom { get { return Top - Height; } }

            public double Right { get { return Left + Width; } }

            public bool IsInside(Rectangle other)
            {
                return Left >= other.Left && Right <= other.Right && Top <= other.Top && Bottom >= other.Bottom;
            }
        }

        static void Main(string[] args)
        {
            Rectangle r1 = ReadRectangle();
            Rectangle r2 = ReadRectangle();

            if(r1.IsInside(r2))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }

        static Rectangle ReadRectangle()
        {
            var rectangleInfo = Console.ReadLine().Split().Select(double.Parse);

            Rectangle r = new Rectangle();

            r.Left = rectangleInfo.First();
            r.Top = rectangleInfo.Skip(1).First();
            r.Width = rectangleInfo.Skip(2).First();
            r.Height = rectangleInfo.Skip(3).First();

            return r;
        }
    }
}
