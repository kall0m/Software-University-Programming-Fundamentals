using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            var productsDatabase = new Dictionary<string, List<double>>();

            var input = Console.ReadLine().Split().ToList();

            while(input[0] != "stocked")
            {
                var productName = input[0];
                var productPrice = double.Parse(input[1]);
                var productQuantity = long.Parse(input[2]);

                if (!productsDatabase.ContainsKey(productName))
                {
                    productsDatabase[productName] = new List<double>();

                    productsDatabase[productName].Add(productPrice);
                    productsDatabase[productName].Add(productQuantity);
                }
                else
                {
                    productsDatabase[productName][0] = productPrice;
                    productsDatabase[productName][1] += productQuantity;
                }

                input = Console.ReadLine().Split().ToList();
            }

            var grandTotal = 0.0;

            foreach (var product in productsDatabase)
            {
                var total = product.Value[0] * product.Value[1];

                grandTotal += total;

                Console.WriteLine($"{product.Key}: ${product.Value[0]:F2} * {product.Value[1]} = ${total:F2}");
            }

            Console.WriteLine(new string('-', 30));

            Console.WriteLine($"Grand Total: ${grandTotal:F2}");
        }
    }
}
