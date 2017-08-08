using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upgraded_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split(' ').ToArray();
            long[] quantity = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            decimal[] price = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            Array.Resize(ref quantity, products.Length);

            string[] product = Console.ReadLine().Split(' ').ToArray();

            while (product[0] != "done")
            {
                PrintProductStats(products, quantity, price, product);

                product = Console.ReadLine().Split(' ').ToArray();
            }
        }

        static void PrintProductStats(string[] products, long[] quantity, decimal[] price, string[] product)
        {
            long quantityOfProduct = long.Parse(product[1]);

            for (int i = 0; i < products.Length; i++)
            {
                if (product[0] == products[i])
                {
                    if (quantityOfProduct <= quantity[i])
                    {
                        Console.WriteLine($"{product[0]} x {quantityOfProduct} costs {quantityOfProduct * price[i]:F2}");
                        quantity[i] -= quantityOfProduct;
                    }
                    else
                    {
                        Console.WriteLine($"We do not have enough {product[0]}");
                    }
                }
            }
        }
    }
}
