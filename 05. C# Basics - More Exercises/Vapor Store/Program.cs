using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vapor_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            double price = 0.0;
            string boughtGame = "";
            double beginningBalance = balance;

            while(true)
            {
                string order = Console.ReadLine();

                if(order == "Game Time")
                {
                    break;
                }

                switch (order)
                {
                    case "OutFall 4": price = 39.99; boughtGame = order; break;
                    case "CS: OG": price = 15.99; boughtGame = order; break;
                    case "Zplinter Zell": price = 19.99; boughtGame = order; break;
                    case "Honored 2": price = 59.99; boughtGame = order; break;
                    case "RoverWatch": price = 29.99; boughtGame = order; break;
                    case "RoverWatch Origins Edition": price = 39.99; boughtGame = order; break;
                    default: boughtGame = "not found"; break;
                }

                if(boughtGame == "not found")
                {
                    Console.WriteLine("Not Found");
                    continue;
                }

                if (balance == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }

                if (balance < price)
                {
                    Console.WriteLine("Too Expensive");
                }
                else
                {
                    Console.WriteLine($"Bought {boughtGame}");
                    balance -= price;
                }
            }

            if(balance != 0)
            {
                Console.WriteLine($"Total spent: ${beginningBalance - balance:F2}. Remaining: ${balance:F2}");
            }
        }
    }
}
