using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {
            var cash = decimal.Parse(Console.ReadLine());
            var guests = long.Parse(Console.ReadLine());
            var bananaPrice = decimal.Parse(Console.ReadLine());
            var eggsPrice = decimal.Parse(Console.ReadLine());
            var berriesPriceKG = decimal.Parse(Console.ReadLine());

            decimal sets = Math.Ceiling(guests / 6m);
            var totalPortions = sets * 6;

            var neededMoney = sets * (2 * bananaPrice) + sets * (4 * eggsPrice) + sets * (0.2m * berriesPriceKG);

            if(neededMoney <= cash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {neededMoney:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {neededMoney - cash:F2}lv more.");
            }
        }
    }
}