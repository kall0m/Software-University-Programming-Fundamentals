using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingredients = "";
            int count = 0;

            while(true)
            {
                ingredients = Console.ReadLine();
                if(ingredients == "Bake!")
                {
                    break;
                }
                Console.WriteLine("Adding ingredient {0}.", ingredients);
                count++;
            }

            Console.WriteLine("Preparing cake with {0} ingredients.", count);
        }
    }
}
