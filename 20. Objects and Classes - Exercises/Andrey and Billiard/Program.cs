using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andrey_and_Billiard
{
    class Program
    {
        class Customer
        {
            public string Name { get; set; }
            public Dictionary<string, int> ShopList { get; set; }
            public decimal Bill { get; set; }
        }

        static void Main(string[] args)
        {
            var shop = ReadProducts();

            var customers = ReadCustomers(shop);

            PrintCustomers(customers);
        }

        static void PrintCustomers(List<Customer> customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine($"{customer.Name}");

                foreach (KeyValuePair<string, int> product in customer.ShopList)
                {
                    Console.WriteLine($"-- {product.Key} - {product.Value}");
                }

                Console.WriteLine($"Bill: {customer.Bill:F2}");
            }

            Console.WriteLine("Total bill: {0:F2}", customers.Select(c => c.Bill).Sum());
        }

        static List<Customer> ReadCustomers(Dictionary<string, decimal> shop)
        {
            var customers = new SortedDictionary<string, Customer>();

            var input = Console.ReadLine();

            while(input != "end of clients")
            {
                var customerInfo = input.Split('-', ',');

                var customerName = customerInfo[0];
                var product = customerInfo[1];
                var quantity = int.Parse(customerInfo[2]);

                if (!shop.ContainsKey(product))
                {
                    input = Console.ReadLine();
                    continue;
                }

                if (!customers.ContainsKey(customerName))
                {
                    customers[customerName] = new Customer()
                    {
                        Name = customerName,
                        ShopList = new Dictionary<string, int>(),
                        Bill = 0
                    };
                }

                if (!customers[customerName].ShopList.ContainsKey(product))
                {
                    customers[customerName].ShopList.Add(product, 0);
                }

                customers[customerName].ShopList[product] += quantity;
                customers[customerName].Bill += quantity * shop[product];

                input = Console.ReadLine();
            }

            return customers.Select(v => v.Value).ToList();
        }

        static Dictionary<string, decimal> ReadProducts()
        {
            var shop = new Dictionary<string, decimal>();

            int numberOfProducts = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfProducts; i++)
            {
                var products = Console.ReadLine().Split('-');

                shop[products[0]] = decimal.Parse(products[1]);
            }

            return shop;
        }
    }
}
