using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Report
{
    class Program
    {
        class Sale
        {
            public string Town { get; set; }
            public string Product { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var salesByTown = new SortedDictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                Sale sale = ReadSale();

                if (!salesByTown.ContainsKey(sale.Town))
                {
                    salesByTown[sale.Town] = sale.Price * sale.Quantity;
                }
                else
                {
                    salesByTown[sale.Town] += sale.Price * sale.Quantity;
                }
            }

            foreach (var pair in salesByTown)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value:F2}");
            }
        }

        static Sale ReadSale()
        {
            var saleInfo = Console.ReadLine().Split();

            Sale sale = new Sale()
            {
                Town = saleInfo.First(),
                Product = saleInfo.Skip(1).First(),
                Price = decimal.Parse(saleInfo.Skip(2).First()),
                Quantity = decimal.Parse(saleInfo.Skip(3).First())
            };

            return sale;
        }
    }
}
