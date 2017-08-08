using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int waterTankCapacity = 255;
            double litersInTank = 0.0;

            for (int i = 0; i < n; i++)
            {
                double litersWater = double.Parse(Console.ReadLine());

                if (litersWater > waterTankCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    waterTankCapacity -= (int)litersWater;
                    litersInTank += litersWater;
                }
            }

            Console.WriteLine(litersInTank);
        }
    }
}
