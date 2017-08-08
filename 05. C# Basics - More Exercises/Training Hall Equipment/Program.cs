using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Hall_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int nuberOfItems = int.Parse(Console.ReadLine());
            double subtotal = 0.0;

            for (int i = 0; i < nuberOfItems; i++)
            {
                string itemName = Console.ReadLine();
                double itemPrice = double.Parse(Console.ReadLine());
                int itemCount = int.Parse(Console.ReadLine());

                if(itemCount > 1)
                {
                    itemName += "s";
                }
                Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
                subtotal += itemPrice * itemCount;
            }

            Console.WriteLine($"Subtotal: ${subtotal:F2}");

            if(subtotal <= budget)
            {
                Console.WriteLine($"Money left: ${budget - subtotal:F2}");
            }
            else
            {
                Console.WriteLine($"Not enough. We need ${subtotal - budget:F2} more.");
            }
        }
    }
}
