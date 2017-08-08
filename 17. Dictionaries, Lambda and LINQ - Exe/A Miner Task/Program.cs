using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var resources = new Dictionary<string, long>();

            var resourceName = Console.ReadLine();

            while (resourceName != "stop")
            {
                var resourceQuantity = long.Parse(Console.ReadLine());

                if (resources.ContainsKey(resourceName))
                {
                    resources[resourceName] += resourceQuantity;
                }
                else
                {
                    resources[resourceName] = resourceQuantity;
                }

                resourceName = Console.ReadLine();
            }

            foreach (var pair in resources)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
