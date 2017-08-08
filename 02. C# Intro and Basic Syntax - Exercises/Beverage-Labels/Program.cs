using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int ml = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int sugar = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}ml {1}:\n{2}kcal, {3}g sugars", ml, name, (ml * energy) / 100.0, (ml * sugar) / 100.0);
        }
    }
}
