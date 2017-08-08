using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int group = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            double price = 0.0;
            string hall = "";
            double pricepp = 0.0;

            if(group <= 50)
            {
                hall = "Small Hall";
                price = 2500;
            }
            else if(group <= 100)
            {
                hall = "Terrace";
                price = 5000;
            }
            else if(group <= 120)
            {
                hall = "Great Hall";
                price = 7500;
            }

            if (package == "Normal")
            {
                price += 500;
                price = price - price * 0.05;
            }
            else if (package == "Gold")
            {
                price += 750;
                price = price - price * 0.1;
            }
            else if (package == "Platinum")
            {
                price += 1000;
                price = price - price * 0.15;
            }

            pricepp = price / group;

            if(group > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                Console.WriteLine("We can offer you the {0}", hall);
                Console.WriteLine("The price per person is {0:F2}$", pricepp);
            }
        }
    }
}
