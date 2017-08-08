using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            var evens = ExtractingEvens(numbers);

            TurningEvensIntoOdds(evens);

            Console.WriteLine(string.Join(" ", evens));
        }

        static void TurningEvensIntoOdds(List<double> evens)
        {
            var averageOfEvens = evens.Average();

            for (int i = 0; i < evens.Count; i++)
            {
                if (evens[i] > averageOfEvens)
                {
                    evens[i]++;
                }
                else
                {
                    evens[i]--;
                }
            }
        }

        static List<double> ExtractingEvens(List<double> numbers)
        {
            return numbers.Where(n => n % 2 == 0).ToList();
        }
    }
}
