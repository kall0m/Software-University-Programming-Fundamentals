using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var countryCitiesPopulation = new Dictionary<string, Dictionary<string, long>>();

            var input = Console.ReadLine();

            while(input != "report")
            {
                var city = input.Split('|').First();
                var country = input.Split('|')[1];
                var population = long.Parse(input.Split('|').Last());

                if (!countryCitiesPopulation.ContainsKey(country))
                {
                    countryCitiesPopulation.Add(country, new Dictionary<string, long>());
                }

                countryCitiesPopulation[country][city] = population;

                input = Console.ReadLine();
            }

            foreach (var country in countryCitiesPopulation.OrderByDescending(countryPop => countryPop.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");

                foreach (var city in countryCitiesPopulation[country.Key].OrderByDescending(cityPop => cityPop.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
