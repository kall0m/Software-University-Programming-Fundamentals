using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_a_Drink2
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            if (profession == "Athlete")
            {
                Console.WriteLine("The {0} has to pay {1:F2}.", profession, quantity * 0.7);
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                Console.WriteLine("The {0} has to pay {1:F2}.", profession, quantity);
            }
            else if (profession == "SoftUni Student")
            {
                Console.WriteLine("The {0} has to pay {1:F2}.", profession, quantity * 1.7);
            }
            else
            {
                Console.WriteLine("The {0} has to pay {1:F2}.", profession, quantity * 1.2);
            }
        }
    }
}
