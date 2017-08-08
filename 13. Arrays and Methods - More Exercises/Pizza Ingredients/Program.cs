using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ingredients = Console.ReadLine().Split(' ').ToArray();
            int lengthOfIngredient = int.Parse(Console.ReadLine());
            string[] pizzaIngredients = new string[ingredients.Length];
            int totalIngredients = 0;

            totalIngredients = CountPizzaIngredients(ingredients, lengthOfIngredient, pizzaIngredients, totalIngredients);

            Array.Resize(ref pizzaIngredients, totalIngredients);

            Console.WriteLine($"Made pizza with total of {totalIngredients} ingredients.");
            Console.WriteLine($"The ingredients are: {String.Join(", ", pizzaIngredients)}.");
        }

        static int CountPizzaIngredients(string[] ingredients, int lengthOfIngredient, string[] pizzaIngredients, int totalIngredients)
        {
            for (int i = 0; i < ingredients.Length; i++)
            {
                if (totalIngredients == 10)
                {
                    break;
                }

                if (ingredients[i].Length == lengthOfIngredient)
                {
                    pizzaIngredients[totalIngredients++] = ingredients[i];
                    Console.WriteLine($"Adding {ingredients[i]}.");
                }
            }

            return totalIngredients;
        }
    }
}
