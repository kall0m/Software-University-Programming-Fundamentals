using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Softuni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var countOfOrders = int.Parse(Console.ReadLine());

            decimal totalPrice = 0m;

            long capsulesPerMonth = 0;

            for (int i = 0; i < countOfOrders; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                var orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                long capsulesCount = long.Parse(Console.ReadLine());

                var daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);

                capsulesPerMonth = daysInMonth * capsulesCount;

                Console.WriteLine("The price for the coffee is: ${0:f2}", pricePerCapsule * capsulesPerMonth);

                totalPrice += pricePerCapsule * capsulesPerMonth;
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
