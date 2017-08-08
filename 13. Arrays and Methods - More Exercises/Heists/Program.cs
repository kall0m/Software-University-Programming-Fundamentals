using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] prices = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long jewelsPrice = prices[0];
            long goldPrice = prices[1];

            long[] totalEarningsAndExpenses = new long[2];

            totalEarningsAndExpenses = CountEarningsAndExpenses(jewelsPrice, goldPrice, totalEarningsAndExpenses);

            if (totalEarningsAndExpenses[0] >= totalEarningsAndExpenses[1])
            {
                Console.WriteLine($"Heists will continue. Total earnings: {totalEarningsAndExpenses[0] - totalEarningsAndExpenses[1]}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {totalEarningsAndExpenses[1] - totalEarningsAndExpenses[0]}.");
            }
        }

        static long[] CountEarningsAndExpenses(long jewelsPrice, long goldPrice, long[] totalEarningsAndExpenses)
        {
            string[] command = Console.ReadLine().Split(' ').ToArray();

            while (command[0] != "Jail" && command[1] != "Time")
            {
                for (int i = 0; i < command[0].Length; i++)
                {
                    if (command[0][i] == '%')
                    {
                        totalEarningsAndExpenses[0] += jewelsPrice;
                    }

                    if (command[0][i] == '$')
                    {
                        totalEarningsAndExpenses[0] += goldPrice;
                    }
                }

                totalEarningsAndExpenses[1] += long.Parse(command[1]);

                command = Console.ReadLine().Split(' ').ToArray();
            }

            return totalEarningsAndExpenses;
        }
    }
}
