using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split(' ').ToArray();
            long[] quantity = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            decimal[] price = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            string nameOfProduct = Console.ReadLine();

            while(nameOfProduct != "done")
            {
                PrintProductStats(products, quantity, price, nameOfProduct);

                nameOfProduct = Console.ReadLine();
            }
        }

        static void PrintProductStats(string[] products, long[] quantity, decimal[] price, string nameOfProduct)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (nameOfProduct == products[i])
                {
                    Console.WriteLine($"{nameOfProduct} costs: {price[i]}; Available quantity: {quantity[i]}");
                }
            }
        }
    }
}
