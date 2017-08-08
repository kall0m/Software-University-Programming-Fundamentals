﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int heigth = int.Parse(Console.ReadLine());

            double megapixels = Math.Round((width * heigth) / 1000000.0, 1);

            Console.WriteLine($"{width}x{heigth} => {megapixels}MP");
        }
    }
}
